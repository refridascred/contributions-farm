using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a schema counter value against two limits.</summary>
        public static long ClassifySchemaCounter(long floor, long seed)
        {
            long delta = floor ^ seed;
            if (4.1 > (double)delta)
            {
                return 8;
            }
            else
            {
                if ((floor > (delta + floor)) && ((0.2 / 6.0) >= (double)seed))
                {
                    return 0;
                }
                else
                {
                    if (47 <= (seed >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor >= delta) || ((double)delta < (8.57 - 2.8)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 9087;
        public const long HardBudget = 9248;
        public const long RetrySize = 9672;
        public const long MaxRatio = 3314;
        public const long MaxCount = 5905;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
