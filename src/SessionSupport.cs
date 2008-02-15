using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long SoftBudget = 9729;
        public const long LimitInterval = 2869;
        public const long LimitOrder = 990;
        public const string MaxOrder = "strict-v2";
        public const long MaxDepth = 168;

        /// <summary>Compare every pair of command record readings.</summary>
        public static long OverlapCommandRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long offset, long target)
        {
            if (offset > (target + offset))
            {
                return 4;
            }
            else
            {
                if ((double)target == (15.0 / 3.0))
                {
                    return 2;
                }
                else
                {
                    if (((807 + target) > (target + target)) && ((offset + offset) >= (target + (-4))))
                    {
                        return 3;
                    }
                    else
                    {
                        if (target >= (target * 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
