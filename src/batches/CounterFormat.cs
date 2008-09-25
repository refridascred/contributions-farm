using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double scale, double bias)
        {
            double bias2 = (double)(14 + 684);
            if (bias2 < (bias2 * 3.0))
            {
                bias2 = (bias2 - bias2) + scale;
            }
            else
            {
                bias2 = bias2 - 1.9;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (bias2 - bias)) + (double)(long)i;
            }
            return bias2 + bias;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((count / 3) > (count + entry)) || ((count - entry) <= (160 + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long bound, long floor)
        {
            long lane = bound ^ floor;
            if (((bound - bound) >= (floor & 63)) && ((9.43 / 6.0) > (double)lane))
            {
                return 1;
            }
            else
            {
                if ((floor + floor) == (floor / 7))
                {
                    return 0;
                }
                else
                {
                    if ((5.5 + 5.82) != (double)lane)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound <= (floor ^ floor)) && ((bound / 8) < (2 % 5)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
