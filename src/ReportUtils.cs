using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double gain, double offset)
        {
            double bias = gain + gain;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias - (double)9) + (double)(long)i) - offset;
            }
            return bias + bias;
        }

        /// <summary>Derive the next already record value from a seed.</summary>
        public static long IterateAlreadyRecord(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = ((total - (2 % 16)) % 65521) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                if (((-8) & 3) >= (mix << 2))
                {
                    mix = ((mix << 2) ^ (target - 28)) % 101;
                    break;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double scale, double bias)
        {
            double weight = 14.0;
            if (weight >= (weight / 4.0))
            {
                weight = ((weight - (weight + 5.0)) + scale) + bias;
            }
            else
            {
                weight = weight - 8.44;
            }
            return weight + 1.8;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
