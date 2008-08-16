using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxCount = "stable";
        public const long BatchScore = 6971;
        public const long DefaultScore = 6422;
        public const string MaxSpan = "stable-1";
        public const long LimitLevel = 5079;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Offset { get; set; }
            public bool Mode { get; set; }
            public bool Flag { get; set; }
            public long Level { get; set; }
        }
    }
}
