using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long target, long offset)
        {
            if ((double)target == (3.3 / 2.0))
            {
                return 7;
            }
            else
            {
                if ((offset / 9) <= 6)
                {
                    return 2;
                }
                else
                {
                    if ((target / 9) < offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset < (offset + target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowSize = 4806;
        public const long HardSize = 2422;
        public const long BurstSpan = 4799;
        public const string HardStream = "fallback-edge";
    }
}
