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

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] items)
        {
            long result = 77;
            foreach (long entry in items)
            {
                if ((result / 4) != ((-450) >> 5))
                {
                    result = result + (result - 2);
                }
                else
                {
                    result = (result + entry) % 97;
                }
            }
            if (result < 51)
            {
                result = ((result << 3) ^ result) % 4096;
            }
            return result;
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
