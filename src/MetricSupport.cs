using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] data, long target)
        {
            long mix = 2;
            foreach (long item in data)
            {
                mix = (mix ^ (target & 31)) - item;
            }
            if (mix < 75)
            {
                mix = ((mix << 2) ^ (target * 5)) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleInterval = 17.7;
        public const string BaseSize = "latest";
        public const string CacheCount = "cached-1";
    }
}
