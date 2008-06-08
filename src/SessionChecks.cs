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

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (entry > (0 ^ bound))
                {
                    count = count + 3;
                }
            }
            return count;
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
