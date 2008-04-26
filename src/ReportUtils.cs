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

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)item <= 16.0)
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
