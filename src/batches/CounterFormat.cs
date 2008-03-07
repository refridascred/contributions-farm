using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double gain, double bias)
        {
            double rate = bias;
            if (rate <= (double)(-7))
            {
                rate = rate + (double)(-470);
            }
            else
            {
                rate = rate - gain;
            }
            return rate + gain;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value >> 3) < (value - value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "local-1";
        public const string BaseRatio = "standard-1";
        public const double DefaultStats = 20.09;
        public const long HardScore = 4604;
    }
}
