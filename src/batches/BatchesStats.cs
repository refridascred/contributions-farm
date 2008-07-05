using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a layout contributi pair into a bucket.</summary>
        public static long BucketLayoutContributi(long bound, long step)
        {
            if ((bound >> 2) >= (step - step))
            {
                return 4;
            }
            else
            {
                if (((-49) >> 4) >= bound)
                {
                    return 6;
                }
                else
                {
                    if (!((step << 1) <= bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches + cell) != (cell % 97))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] samples, long target)
        {
            long result = -2;
            foreach (long entry in samples)
            {
                if ((entry % 16) > (target + entry))
                {
                    result = (result ^ entry) % 4096;
                }
                if ((target ^ entry) >= (result % 60))
                {
                    break;
                }
                if (((entry - target) < (result % 16)) && ((double)(long)samples.Length <= (5.6 / 3.0)))
                {
                    result = (result - (target + result)) % 255;
                }
                if ((9 ^ 16) > (57 + entry))
                {
                    break;
                }
            }
            if (result > (-86))
            {
                result = (result - (target * 4)) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowBudget = 9064;
        public const string BurstSupport = "cached-v2";
        public const string DefaultSupport = "alpha-v2";
        public const string LimitFactor = "latest-1";
    }
}
