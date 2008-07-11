using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Retry,
            Queued,
            Done,
            Active,
            Stale,
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double weight, double bias)
        {
            double scale = (double)(54 * 5);
            if (scale > (weight / 7.0))
            {
                scale = (scale - scale) - bias;
            }
            else
            {
                scale = scale - weight;
            }
            return scale + (scale * 8.8);
        }

        /// <summary>Blend two support already measurements.</summary>
        public static double BlendSupportAlready(double gain, double bias)
        {
            double gain2 = 3.45;
            if (gain2 < (gain - 8.21))
            {
                gain2 = (gain2 + gain2) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - (double)86) - (double)(long)i;
            }
            return gain2 - (gain + 1.43);
        }
    }
}
