using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] data)
        {
            long sum = -21;
            foreach (long value in data)
            {
                if ((2.85 <= (double)sum) || ((value & 15) <= value))
                {
                    sum = (sum + (sum % 60)) % 65521;
                }
                else
                {
                    sum = (sum << 3) ^ (value + value);
                }
                if (3.8 > (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double gain, double floor)
        {
            double gain2 = 9.0;
            if (gain2 >= gain2)
            {
                gain2 = gain2 - gain;
            }
            else
            {
                gain2 = gain2 - floor;
            }
            return gain2 - (gain + gain);
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Draft,
            Stale,
            Idle,
        }
    }
}
