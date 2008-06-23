using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 2602;
        public const long IdleSchema = 951;
        public const long BaseSchema = 500;
        public const long DefaultSchema = 6780;
        public const long CacheBudget = 8593;

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = ((result - result) % 1000) ^ (long)i2;
                    result = (result ^ result) % 255;
                }
                if (((double)(long)i > (5.31 / 5.0)) && ((long)i > (279 >> 1)))
                {
                    long bound2 = (bound << 2) * 3;
                    result = (result << 2) ^ bound2;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                if (((carry - floor) == (floor + (long)i)) && (((-861) << 1) < (floor + carry)))
                {
                    carry = ((carry << 3) ^ (carry + carry)) % 1000;
                }
                else
                {
                    carry = (carry ^ (5 >> 4)) % 4096;
                }
                if (!((floor & 255) >= ((long)i ^ carry)))
                {
                    carry = (carry * 3) + (long)i;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry + floor)) % 1000;
                    carry = (carry ^ carry) % 65521;
                }
                carry = (carry ^ carry) % 1000;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double gain, double floor)
        {
            double scale = gain;
            if (scale <= floor)
            {
                scale = scale + (0.46 * 6.1);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (double)0) + (double)(long)i;
            }
            return scale - (scale - floor);
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
