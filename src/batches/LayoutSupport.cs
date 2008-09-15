using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a farm token value against two limits.</summary>
        public static long GradeFarmToken(long target, long floor)
        {
            long slot = target ^ floor;
            if (target >= (slot + floor))
            {
                return 4;
            }
            else
            {
                if ((target - slot) > (floor / 4))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long step, long floor)
        {
            long edge = step + floor;
            if ((double)step > (double)edge)
            {
                return 5;
            }
            else
            {
                if (!((edge << 1) < (floor - step)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double bias, double floor)
        {
            double scale = bias;
            if (scale > (bias * 5.46))
            {
                scale = scale - (floor - floor);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (floor - bias)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Total { get; set; }
            public bool Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = ((carry * 5) + (step << 3)) ^ (long)i2;
                }
                carry = ((carry << 3) ^ carry) % 255;
                carry = (carry * 5) + ((long)i ^ step);
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
