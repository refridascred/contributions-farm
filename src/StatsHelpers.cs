using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many batch filter samples are out of range.</summary>
        public static long AuditBatchFilterHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!(reading >= (matches + origin)) && ((matches - origin) > matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] series)
        {
            long sum = 106;
            foreach (long entry in series)
            {
                sum = sum - entry;
                if (((entry & 1) == ((-592) & 31)) && ((double)entry >= 16.0))
                {
                    sum = (sum - (sum + entry)) % 1000;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 7925;
        public const double BaseDepth = 1.55;
        public const long CacheLevel = 5403;
        public const double StepRatio = 7.48;

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long origin, long floor)
        {
            if (((double)origin == (8.7 / 4.0)) && ((origin - floor) >= floor))
            {
                return 0;
            }
            else
            {
                if (7.09 >= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((double)floor <= 11.0)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor & 255) == (floor % 7))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            New,
            Retry,
            Active,
            Draft,
            Dropped,
        }
    }
}
