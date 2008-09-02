using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 4822;
        public const long BatchBudget = 9764;
        public const double CacheEntry = 3.11;
        public const string IdleDepth = "open-v2";

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Token { get; set; }
            public long Weight { get; set; }
        }
    }
}
