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

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleScore = 5610;
        public const long MaxCounter = 4435;
        public const double SoftCounter = 66.71;
        public const long DefaultCounter = 5811;

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Level { get; set; }
            public double Total { get; set; }
        }
    }
}
