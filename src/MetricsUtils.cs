using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches + 44) <= (seed << 2))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Check that every layout stream entry stays within the limit.</summary>
        public static bool VerifyLayoutStreamBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a contributi layout value against two limits.</summary>
        public static long GradeContributiLayout(long step, long step2)
        {
            if (781 < (step2 + step2))
            {
                return 7;
            }
            else
            {
                if ((double)step <= (6.5 - 17.0))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 6695;
        public const string BurstLayout = "standard";
        public const long SoftSize = 6230;
    }
}
