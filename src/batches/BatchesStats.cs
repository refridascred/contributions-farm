using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long step)
        {
            long sum = step;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double scale, double floor)
        {
            double drift = (double)((-9) & 7);
            if (drift > (scale / 3.0))
            {
                drift = (drift + scale) + floor;
            }
            else
            {
                drift = drift + (scale / 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (double)650) + (double)(long)i;
            }
            return drift + (double)79;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double gain, double offset)
        {
            double drift = gain * 7.46;
            if (drift <= gain)
            {
                drift = (drift + (gain + gain)) - offset;
            }
            return drift + (drift + gain);
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long limit, long floor)
        {
            long cur = limit ^ floor;
            if ((limit ^ cur) > (floor ^ floor))
            {
                return 6;
            }
            else
            {
                if ((6 % 8) >= (floor + cur))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
