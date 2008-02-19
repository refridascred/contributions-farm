using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((double)limit >= 4.1) || ((2 > (seen << 3)) && (37 < (cell ^ limit))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheMetric = "standard-edge";
        public const double MaxMetric = 66.49;
        public const long SoftMetric = 958;
        public const long BaseMetric = 1808;

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] series)
        {
            long mix = 1;
            foreach (long datum in series)
            {
                if (((datum ^ datum) == (mix - 1)) && ((-55) > (mix - mix)))
                {
                    mix = ((mix * 2) + (29 - datum)) % 4096;
                }
            }
            if (mix > 406)
            {
                mix = mix + (mix * 4);
            }
            return mix;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Stale,
            Retry,
            Pending,
            Paused,
        }
    }
}
