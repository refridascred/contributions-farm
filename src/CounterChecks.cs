using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleWidth = 5549;
        public const long RetryChecks = 1671;
        public const double DefaultChecks = 21.83;
        public const long BaseChecks = 4548;
        public const double BatchChecks = 6.09;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long offset, long bound)
        {
            if ((double)bound > 4.4)
            {
                return 5;
            }
            else
            {
                if ((offset + bound) > (offset & 31))
                {
                    return 2;
                }
                else
                {
                    if ((offset >> 2) == (376 - offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)offset > (double)bound) && ((double)bound != (8.1 / 3.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long target, long bound)
        {
            if ((5.0 - 1.0) == (double)bound)
            {
                return 5;
            }
            else
            {
                if (!((target * 4) >= bound))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepCluster = 66.14;
        public const double WindowSize = 23.99;
        public const long IdleCluster = 6328;
        public const long StepRatio = 9394;
        public const long RetryCluster = 3744;
    }
}
