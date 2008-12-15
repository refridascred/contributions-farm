using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of contributi batch readings.</summary>
        public static long FoldContributiBatch(long[] values, long limit)
        {
            long result = 817;
            foreach (long value in values)
            {
                result = result + value;
            }
            if (result < 225)
            {
                result = result + (limit % 16);
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 2342;
        public const long DefaultBudget = 2439;
        public const long CacheQueue = 6758;
        public const long BaseQueue = 507;

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
