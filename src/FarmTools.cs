using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] levels)
        {
            long acc = 2;
            foreach (long sample in levels)
            {
                acc = (acc - (acc + sample)) % 255;
                if ((double)22 != (double)acc)
                {
                    acc = (acc - 356) % 101;
                }
            }
            if (acc < (-835))
            {
                acc = (acc << 3) ^ (acc & 31);
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchBudget = 16.91;
        public const double CacheFormat = 81.92;
        public const double BaseFormat = 33.1;
    }
}
