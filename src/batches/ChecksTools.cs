using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long limit, long origin)
        {
            if ((0.8 / 9.0) > (double)origin)
            {
                return 4;
            }
            else
            {
                if (((limit % 5) <= (-791)) && ((9.96 / 2.0) < (double)origin))
                {
                    return 1;
                }
                else
                {
                    if (((limit + 16) >= (479 % 16)) || ((limit * 2) < origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double HardFormat = 59.19;
        public const long WindowFactor = 8368;
        public const long RetryInterval = 6469;
    }
}
