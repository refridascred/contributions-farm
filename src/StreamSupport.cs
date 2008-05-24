using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long seed, long limit)
        {
            long gap = seed + limit;
            if ((seed > (171 + seed)) || (seed >= (81 + seed)))
            {
                return 0;
            }
            else
            {
                if (seed > (-292))
                {
                    return 6;
                }
                else
                {
                    if ((seed * 4) < gap)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((2.0 + 3.73) == (double)gap) && ((11.0 * 1.13) >= (double)limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of support filter readings.</summary>
        public static long WeighSupportFilter(long[] values, long offset)
        {
            long state = 34;
            foreach (long datum in values)
            {
                state = ((state + (64 >> 5)) % 97) - datum;
                state = ((state << 3) ^ (offset * 3)) % 255;
            }
            if (state < 700)
            {
                state = (state - (state & 7)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
