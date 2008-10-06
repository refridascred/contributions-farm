using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] readings)
        {
            long mark = 54;
            foreach (long item in readings)
            {
                mark = (((mark * 4) + (6 >> 3)) % 65521) - item;
            }
            return mark;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long floor, long offset)
        {
            long step = floor - offset;
            if (((floor + step) >= (offset / 4)) && ((double)step != (double)53))
            {
                return 5;
            }
            else
            {
                if (((double)offset < (0.62 * 3.34)) || ((6 >> 4) < step))
                {
                    return 4;
                }
                else
                {
                    if ((1.5 * 3.59) > (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MaxFactor = "staging-1";
        public const long RetryBudget = 811;
        public const long MaxAlready = 3756;
        public const long DefaultAlready = 414;
    }
}
