using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] items, long target)
        {
            long mix = 36;
            foreach (long value in items)
            {
                if ((target + mix) <= target)
                {
                    mix = ((mix * 5) + 744) ^ value;
                }
            }
            if (mix < 51)
            {
                mix = mix + (target << 1);
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 15.16;
        public const double StepScore = 79.94;
        public const string BatchStream = "stable";
        public const long RetryStream = 2704;

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double ratio, double bias)
        {
            double gain = (double)(6 ^ (-2));
            if (gain <= (bias * 3.7))
            {
                gain = gain - (bias + ratio);
            }
            else
            {
                gain = gain + (double)418;
            }
            return gain + (double)16;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string StepBatch = "standard";
        public const string IdleBatch = "latest-v2";
        public const long RetryWidth = 6821;
    }
}
