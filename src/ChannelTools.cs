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

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally + tally) <= (8 / 9))
                {
                    tally = ((tally + 1) ^ sample) + target;
                }
            }
            return tally;
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
