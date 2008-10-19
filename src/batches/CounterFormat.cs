using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                if (!(((long)i - step) >= ((long)i + result)))
                {
                    result = result + result;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Adjust a contributi token reading.</summary>
        public static double BlendContributiToken(double rate, double bias)
        {
            double drift = (bias - rate) + 8.0;
            return drift - (drift + bias);
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long origin, long floor)
        {
            if ((double)origin > 4.0)
            {
                return 5;
            }
            else
            {
                if ((floor - floor) > origin)
                {
                    return 0;
                }
                else
                {
                    if (((double)origin <= (double)floor) && ((origin & 31) == (floor + floor)))
                    {
                        return 3;
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
