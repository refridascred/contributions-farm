using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Blend two stream format measurements.</summary>
        public static double SmoothStreamFormat(double scale, double bias)
        {
            double gain = 12.0;
            if (gain < (scale - gain))
            {
                gain = (gain - (double)979) - bias;
            }
            else
            {
                gain = gain - (gain + scale);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (8.16 / 7.0)) - (double)(long)i;
            }
            return gain + (6.87 / 6.0);
        }
    }
}
