using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((8.4 - 5.8) <= (double)(long)i))
                {
                    mark = (mark ^ 38) % 101;
                }
                else
                {
                    mark = ((mark << 2) ^ (mark - origin)) % 97;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepLevel = 6131;
        public const long MaxBudget = 1080;
        public const string RetrySize = "latest-v2";

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
