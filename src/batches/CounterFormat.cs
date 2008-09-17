using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
