using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 9562;
        public const long WindowContext = 7641;
        public const long BurstSpan = 1432;
        public const double BatchContext = 97.73;
        public const long RetryContext = 9627;

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long offset, long limit)
        {
            if (((7.26 / 2.0) <= (double)offset) && ((limit + offset) != (offset + limit)))
            {
                return 3;
            }
            else
            {
                if (((19.0 - 9.77) == (double)limit) && (5.22 >= (double)limit))
                {
                    return 7;
                }
                else
                {
                    if (!((offset ^ limit) <= (limit % 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstCount = 375;
        public const long MaxFactor = 9268;
        public const long DefaultSession = 9180;
        public const long MaxSession = 8436;
    }
}
