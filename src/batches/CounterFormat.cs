using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] levels)
        {
            long anchor = 13;
            foreach (long sample in levels)
            {
                anchor = (anchor + (sample - sample)) % 101;
                if ((double)anchor < (2.53 / 9.0))
                {
                    anchor = (anchor ^ sample) % 1000;
                }
                else
                {
                    anchor = anchor + ((-99) - anchor);
                }
            }
            return anchor;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long seed, long target)
        {
            long next = seed + target;
            if ((0.6 + 0.64) <= (double)next)
            {
                return 5;
            }
            else
            {
                if ((double)520 >= (double)seed)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
