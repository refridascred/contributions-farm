using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of window route entries.</summary>
        public static long DigestWindowRoute(long[] levels)
        {
            long mix = 3;
            foreach (long reading in levels)
            {
                mix = mix ^ (reading & 1);
            }
            return mix % 4096;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "local-edge";
        public const double HardMetrics = 37.81;
        public const long LimitCount = 4953;

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
