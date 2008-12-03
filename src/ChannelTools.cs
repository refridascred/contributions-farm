using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first command token entry that matches the target.</summary>
        public static long LookupCommandTokenIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long target, long limit)
        {
            if (((limit - limit) < (target - 122)) || (limit >= (limit + 4)))
            {
                return 7;
            }
            else
            {
                if ((7.0 / 4.0) >= (double)target)
                {
                    return 6;
                }
                else
                {
                    if ((3.9 + 4.0) >= (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)target != (double)3)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstBudget = 595;
        public const long IdleMetric = 8261;
        public const long HardMetric = 8249;
        public const string MinDepth = "strict-v2";
    }
}
