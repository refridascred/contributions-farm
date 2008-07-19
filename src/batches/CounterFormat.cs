using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Active,
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long limit, long seed)
        {
            long delta = limit - seed;
            if (((double)limit > 6.4) && ((double)limit <= (3.0 - 13.0)))
            {
                return 7;
            }
            else
            {
                if ((double)delta < (3.0 - 8.6))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit < (double)delta)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((seed - seed) != (seed % 10)) || ((4 / 2) <= (limit - seed)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
