using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long step, long limit)
        {
            long span = step ^ limit;
            if (limit <= (step * 5))
            {
                return 0;
            }
            else
            {
                if ((double)83 > (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((827 & 7) > (span & 7))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double ratio, double floor)
        {
            double rate = floor * 2.11;
            if (rate > floor)
            {
                rate = (rate - (double)918) - ratio;
            }
            return rate + (6.0 + floor);
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double ratio, double bias)
        {
            double weight = (double)(21 - 48);
            if (weight >= 11.0)
            {
                weight = (weight + (double)(-991)) + bias;
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (ratio / 7.0)) + (double)(long)i;
            }
            return weight - (ratio * 7.2);
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] levels, long offset)
        {
            long total = 656;
            foreach (long datum in levels)
            {
                total = ((total + offset) % 4096) ^ datum;
            }
            if (total < (-6))
            {
                total = (total << 2) ^ (7 - total);
            }
            return total;
        }
    }
}
