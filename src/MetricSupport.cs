using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstRatio = 6946;
        public const long LimitFactor = 7937;
        public const double RetryBudget = 49.17;
        public const long CacheRatio = 9637;

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Label { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((sample & 3) != (sample << 3)) || ((matches - sample) >= (matches - 563)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
