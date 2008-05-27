using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long target, long bound)
        {
            if ((4 + target) <= (target * 5))
            {
                return 5;
            }
            else
            {
                if (!((target ^ target) > (bound >> 4)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseBudget = 3659;
        public const string StepCache = "strict-edge";
        public const long SoftLevel = 2998;
        public const long LimitWidth = 5852;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count % 60) < count)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)seed <= (16.0 - 6.84))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }
    }
}
