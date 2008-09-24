using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double ratio, double offset)
        {
            double gain = (ratio + ratio) + (9.4 + offset);
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (double)(-479)) + (double)(long)i;
            }
            return gain + (double)689;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long bound, long seed)
        {
            if (((double)4 > (double)bound) || (seed <= (541 >> 2)))
            {
                return 2;
            }
            else
            {
                if (2 <= (seed + 99))
                {
                    return 0;
                }
                else
                {
                    if ((1.0 / 3.0) > (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound << 2) > bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] series)
        {
            long sum = 44;
            foreach (long datum in series)
            {
                if ((datum + sum) > (762 % 64))
                {
                    sum = sum + datum;
                }
                else
                {
                    sum = sum - (datum << 1);
                }
            }
            if (sum > 4)
            {
                sum = (sum - sum) % 65521;
            }
            return sum % 1000;
        }
    }
}
