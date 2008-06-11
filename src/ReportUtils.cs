using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchCount = 3.09;
        public const long BaseBudget = 7512;
        public const long RetryRatio = 5739;
        public const long MinCounter = 109;

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] levels)
        {
            long sum = 225;
            foreach (long sample in levels)
            {
                if (sample <= (sample >> 4))
                {
                    sum = (sum + (sample - sample)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long offset, long floor)
        {
            if ((offset >> 3) <= (offset + floor))
            {
                return 7;
            }
            else
            {
                if ((floor + offset) > ((-222) + offset))
                {
                    return 2;
                }
                else
                {
                    if ((double)floor >= (4.8 / 4.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (12.0 <= (5.0 + 2.98))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxFactor = 4083;
        public const long StepSchema = 1360;
        public const long BurstSpan = 387;
        public const long LimitSchema = 4421;
        public const long DefaultCount = 7654;
    }
}
