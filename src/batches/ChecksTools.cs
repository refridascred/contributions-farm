using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long bound, long origin)
        {
            if ((double)bound < (4.7 * 0.48))
            {
                return 4;
            }
            else
            {
                if (((7.9 - 7.52) < (7.6 + 3.71)) || ((bound - origin) < origin))
                {
                    return 0;
                }
                else
                {
                    if (!((9.0 * 5.7) == (double)bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound / 5) != (bound / 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowEditor = 23.73;
        public const double RetryEditor = 31.78;
        public const long StepBudget = 894;

        /// <summary>Find the first stream cache entry that matches the target.</summary>
        public static long LookupStreamCacheIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
