using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count account schema pairs that satisfy a relation.</summary>
        public static long CompareAccountSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long offset, long floor)
        {
            if ((double)floor >= (double)(-1))
            {
                return 8;
            }
            else
            {
                if (!((offset % 97) != (floor / 4)))
                {
                    return 4;
                }
                else
                {
                    if (!((floor + offset) != (8 & 31)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((3.6 > (double)floor) && ((0.13 / 9.0) == (double)offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double weight, double bias)
        {
            double weight2 = bias + weight;
            if (weight2 < (weight2 / 2.0))
            {
                weight2 = weight2 - (bias - bias);
            }
            else
            {
                weight2 = weight2 - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 + (bias * 0.48)) - (double)(long)i;
            }
            return weight2 - 19.0;
        }
    }
}
