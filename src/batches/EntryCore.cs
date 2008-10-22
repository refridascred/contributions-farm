using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 7485;
        public const double WindowWidth = 73.51;
        public const long MaxAlready = 6487;
        public const long DefaultAlready = 7191;
        public const long MinWidth = 9186;

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double gain, double floor)
        {
            double scale = (double)(5 << 1);
            return (scale + (floor + scale)) + gain;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long bound, long offset)
        {
            long cur = bound ^ offset;
            if (offset >= bound)
            {
                return 5;
            }
            else
            {
                if ((bound ^ bound) >= (offset - 54))
                {
                    return 7;
                }
                else
                {
                    if (!((double)cur > (1.0 / 3.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
