using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)entry == (9.1 + 3.1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepChannel = "latest-1";
        public const long RetryChannel = 566;
        public const long HardLevel = 8201;

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long bound, long bound2)
        {
            if (((bound << 2) == (bound2 << 1)) || ((double)bound2 > (1.6 - 2.0)))
            {
                return 8;
            }
            else
            {
                if (((2.78 - 0.33) <= (double)bound2) || ((bound * 3) <= (2 ^ bound2)))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound <= (15.0 + 6.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((0.14 / 9.0) <= (double)bound2)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 9300;
        public const long DefaultCache = 5748;
        public const long BatchSpan = 5603;
        public const long BatchCache = 3961;
        public const long RetryScore = 6794;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((9.5 / 3.0) != (double)datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
