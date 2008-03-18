using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate tools payload readings against a bound.</summary>
        public static bool CheckToolsPayloadLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxRatio = 1786;
        public const long MaxGraph = 2948;
        public const long CacheGraph = 2832;

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long limit, long step)
        {
            if ((step + step) > (step - limit))
            {
                return 4;
            }
            else
            {
                if ((6.49 + 1.1) == (double)limit)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((origin & 31) == ((-168) ^ matches)))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(item >= (27 - 652)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
