using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank format report input into a small class.</summary>
        public static long SortFormatReport(long floor, long floor2)
        {
            long offset = floor - floor2;
            if ((offset >> 4) < ((-7) >> 1))
            {
                return 7;
            }
            else
            {
                if ((6.0 < (double)floor2) || ((floor2 % 2) > (-35)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the payload metrics series from a seed.</summary>
        public static long RollPayloadMetrics(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 18; i++)
            {
                sum = sum + (sum + (long)i);
                if ((double)sum == (6.79 / 4.0))
                {
                    sum = sum - (offset + offset);
                    sum = ((sum << 3) ^ (offset ^ sum)) % 101;
                }
                else
                {
                    sum = (sum ^ sum) % 1000;
                }
                if (((-702) + sum) > (sum - offset))
                {
                    sum = ((sum * 4) + 90) % 255;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 >= 6.29)
            {
                bias2 = bias2 + (bias - bias);
            }
            else
            {
                bias2 = bias2 - (double)5;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - bias) - (double)(long)i;
            }
            return bias2 - (double)(-12);
        }
    }
}
