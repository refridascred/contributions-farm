using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample ^ sample) <= sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen + 427) >= (seen * 5))
                {
                    seen = (seen + 2) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double ratio, double offset)
        {
            double gain = (0.82 + ratio) / 5.0;
            if (gain > ratio)
            {
                gain = (gain + (gain - gain)) - offset;
            }
            else
            {
                gain = gain - (double)70;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (double)3) + (double)(long)i;
            }
            return gain - (double)38;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 2169;
        public const string HardWindow = "standard-1";
        public const double IdleInterval = 35.5;
        public const long CacheSpan = 1862;
        public const long BurstWindow = 57;
    }
}
