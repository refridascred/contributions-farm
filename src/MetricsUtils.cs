using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double MaxLevel = 20.7;
        public const long IdleRoute = 4907;
        public const long MaxRoute = 7792;
        public const long DefaultRoute = 8888;

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] readings, long seed)
        {
            long mix = 1;
            foreach (long value in readings)
            {
                mix = (((mix + (mix / 3)) % 255) + value) - seed;
            }
            if (mix < 469)
            {
                mix = (mix + (mix / 8)) % 101;
            }
            return mix;
        }

        /// <summary>Count the tools context entries that pass the check.</summary>
        public static long TallyToolsContextHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((long)series.Length % 12) <= (value / 4))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen >> 5) == (origin + origin))
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
