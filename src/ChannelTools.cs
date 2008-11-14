using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Dropped,
            Active,
            New,
            Paused,
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            Ready,
            Paused,
            Locked,
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Level { get; set; }
            public double Total { get; set; }
        }
    }
}
