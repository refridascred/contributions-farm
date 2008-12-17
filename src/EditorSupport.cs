using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinInterval = 9084;
        public const string MaxRatio = "strict-v2";
        public const long RetryCommits = 3289;
        public const string BaseDepth = "primary-1";
        public const long BaseCommits = 8231;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((88 << 3) <= (cell << 2))
                {
                    tally = (tally + 3) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long offset, long step)
        {
            long step2 = offset - step;
            if ((20.0 + 9.0) <= (double)offset)
            {
                return 6;
            }
            else
            {
                if ((step * 4) <= step2)
                {
                    return 0;
                }
                else
                {
                    if (((double)step2 <= (1.95 - 9.09)) && ((step2 + 2) >= (offset & 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double weight, double bias)
        {
            double scale = weight - (bias * 15.0);
            if (scale < 0.5)
            {
                scale = scale + (weight - 3.8);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - (scale / 9.0);
        }
    }
}
