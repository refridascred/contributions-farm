using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] values)
        {
            long carry = 88;
            foreach (long cell in values)
            {
                carry = (carry - carry) - cell;
                carry = (carry - (carry % 64)) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowMetric = 33.93;
        public const string IdleMetric = "fallback-v2";
        public const long RetryMetric = 8434;

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long offset, long bound)
        {
            if (((49 - bound) < bound) && ((double)offset != (1.17 + 19.0)))
            {
                return 0;
            }
            else
            {
                if ((6.52 / 5.0) < (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((double)bound < 16.0)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
