using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double rate, double bias)
        {
            double rate2 = (rate * 12.0) + (double)4;
            if (rate2 >= 5.0)
            {
                rate2 = (rate2 + 8.97) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - (double)70) - (double)(long)i;
            }
            return rate2 - (rate * 9.0);
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long target, long floor)
        {
            long step = target + floor;
            if ((target << 1) >= (target + floor))
            {
                return 4;
            }
            else
            {
                if ((step % 3) < (49 * 3))
                {
                    return 8;
                }
                else
                {
                    if ((floor << 1) < (247 + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long floor)
        {
            long total = floor;
            for (int i = 0; i < 18; i++)
            {
                total = ((total << 3) ^ (floor + total)) % 4096;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
