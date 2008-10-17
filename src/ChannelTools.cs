using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 4508;
        public const double HardScore = 6.13;
        public const double BaseFarm = 21.95;
        public const long SoftFactor = 9896;
        public const long RetryTimeout = 2186;

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Synced,
            Locked,
            Retry,
            Idle,
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
