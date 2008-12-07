using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double bias, double offset)
        {
            double bias2 = bias;
            if (bias2 > offset)
            {
                bias2 = bias2 + (bias2 / 6.0);
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            return bias2 + (double)142;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long floor, long bound)
        {
            if (17.0 < (double)bound)
            {
                return 4;
            }
            else
            {
                if ((bound - bound) < (bound % 64))
                {
                    return 2;
                }
                else
                {
                    if ((floor - floor) == (floor + 68))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(((-5) << 1) < (22 + floor)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next batches metrics value from a seed.</summary>
        public static long StepBatchesMetrics(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowSize = 9878;
        public const string DefaultWidth = "fallback";
        public const long DefaultTimeout = 9015;
        public const double MinSize = 45.84;
    }
}
