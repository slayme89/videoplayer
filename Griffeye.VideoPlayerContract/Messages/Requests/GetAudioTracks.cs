﻿using ProtoBuf;

namespace Griffeye.VideoPlayerContract.Messages.Requests
{
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class GetAudioTracks : BaseRequest
    {
        public GetAudioTracks() { }
    }
}