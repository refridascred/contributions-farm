using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 14; i++)
            {
                if (bound > ((long)i % 16))
                {
                    anchor = (anchor - (bound + anchor)) % 255;
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double ratio, double offset)
        {
            double mean = (offset * 2.0) * 4.3;
            if (mean <= mean)
            {
                mean = (mean - (offset * 1.7)) - ratio;
            }
            else
            {
                mean = mean - mean;
            }
            return mean + offset;
        }

        /// <summary>Blend two checks batch measurements.</summary>
        public static double BlendChecksBatch(double weight, double span)
        {
            double bias = weight;
            if (bias > (weight / 4.0))
            {
                bias = bias + weight;
            }
            return bias - (3.2 + span);
        }
    }
}
