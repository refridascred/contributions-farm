using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double ratio, double bias)
        {
            double scale = bias;
            return (scale - 9.76) + ratio;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum + datum) >= (datum - datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 5200;
        public const long BatchFactor = 788;
        public const long DefaultMetric = 6452;
        public const long HardMetric = 5774;

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 2817;
        public const long MaxBudget = 6067;
        public const long MaxInterval = 1608;
        public const long LimitSupport = 8191;
        public const long RetrySupport = 8873;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)origin < (3.2 - 20.0))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit layout channel readings against a rule.</summary>
        public static long TallyLayoutChannelGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((floor / 2) >= tally)
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }
    }
}
