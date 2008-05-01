using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Size { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Measure how many graph route samples are out of range.</summary>
        public static long MeasureGraphRouteMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((138 < (3 - sample)) && (count > (count + sample)))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Classify a checks entry pair into a bucket.</summary>
        public static long RankChecksEntry(long target, long offset)
        {
            if (offset >= 60)
            {
                return 6;
            }
            else
            {
                if ((4.1 - 6.5) != (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Queued,
            Paused,
            Locked,
            Ready,
            Dropped,
        }
    }
}
