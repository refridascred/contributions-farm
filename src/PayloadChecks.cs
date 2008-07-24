using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] items, long target)
        {
            long total = 8;
            foreach (long item in items)
            {
                if (!((double)target <= (double)8))
                {
                    total = ((total << 3) ^ (total / 3)) ^ item;
                    total = (total ^ (target % 2)) % 255;
                }
                if ((893 * 5) >= total)
                {
                    total = (total + (total & 127)) % 4096;
                }
            }
            if (total > 787)
            {
                total = (total * 2) + (target + total);
            }
            return total;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Paused,
            Draft,
            Active,
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double weight, double offset)
        {
            double bias = weight;
            return bias - offset;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((hits & 31) <= (64 % 24)) || ((hits << 3) == ((long)items.Length % 24)))
                {
                    hits = ((hits + 1) + datum) - seed;
                }
            }
            return hits;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long seed, long offset)
        {
            long span = seed ^ offset;
            if ((seed / 5) < span)
            {
                return 7;
            }
            else
            {
                if (offset > (18 & 7))
                {
                    return 1;
                }
                else
                {
                    if ((seed - seed) != (span / 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)span < (double)offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
