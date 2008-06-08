using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double rate, double offset)
        {
            double scale = (double)468 + rate;
            return (scale - (double)(-380)) + offset;
        }

        /// <summary>Digest a series of already graph entries.</summary>
        public static long CombineAlreadyGraph(long[] series)
        {
            long acc = 431;
            foreach (long entry in series)
            {
                acc = ((acc << 3) ^ 68) - entry;
            }
            return acc;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] readings)
        {
            long sum = 399;
            foreach (long value in readings)
            {
                sum = ((sum << 2) ^ value) % 101;
                if ((value % 64) <= sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double gain, double floor)
        {
            double drift = gain + 8.8;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift - (floor + floor);
        }
    }
}
