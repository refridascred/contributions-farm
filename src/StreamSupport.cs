using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double bias, double offset)
        {
            double rate = (bias + 5.0) / 2.0;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - bias) + (double)(long)i) - offset;
            }
            return rate + rate;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] values)
        {
            long total = 247;
            foreach (long value in values)
            {
                total = ((total << 2) ^ value) % 101;
                total = ((total << 2) ^ (597 ^ total)) % 4096;
                if (value > (total - value))
                {
                    break;
                }
            }
            if (total < 528)
            {
                total = (total ^ (total & 127)) % 4096;
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftProfile = 87.64;
        public const long BatchDepth = 4496;
        public const double LimitProfile = 8.18;
        public const string WindowDepth = "legacy";
        public const double RetryProfile = 71.72;
    }
}
