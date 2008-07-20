using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long offset, long floor)
        {
            long prev = offset ^ floor;
            if ((floor - prev) >= offset)
            {
                return 2;
            }
            else
            {
                if ((offset - offset) <= prev)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                if (((99 - acc) > (acc + offset)) || (offset < acc))
                {
                    acc = (acc ^ acc) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
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
