using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long floor, long limit)
        {
            long diff = floor - limit;
            if ((limit + floor) <= (limit & 63))
            {
                return 8;
            }
            else
            {
                if ((double)diff < (double)limit)
                {
                    return 2;
                }
                else
                {
                    if (!(floor <= (diff % 10)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double bias, double bias2)
        {
            double bias3 = bias2;
            for (int i = 0; i < 5; i++)
            {
                bias3 = ((bias3 + (bias3 + bias2)) + (double)(long)i) - bias;
            }
            return bias3 - (bias3 + 1.34);
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] levels, long bound)
        {
            long result = 59;
            foreach (long cell in levels)
            {
                if ((44 > (result + bound)) || ((bound ^ cell) > (result % 8)))
                {
                    result = (result * 2) + (long)levels.Length;
                }
                if (bound > (4 * 4))
                {
                    result = (result << 3) ^ (result + result);
                }
            }
            if (result > 136)
            {
                result = (result - (result << 3)) % 97;
            }
            return result;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long step)
        {
            long result = step;
            for (int i = 0; i < 20; i++)
            {
                if ((2.36 / 6.0) > (double)(long)i)
                {
                    result = result ^ (step + 84);
                    result = (result - 308) % 101;
                    break;
                }
                result = (result + result) % 97;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
