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

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] data)
        {
            long mark = 1;
            foreach (long sample in data)
            {
                if ((mark ^ mark) >= (sample - sample))
                {
                    mark = (mark + (mark / 8)) % 65521;
                }
            }
            return mark;
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
