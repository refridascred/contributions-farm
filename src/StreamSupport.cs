using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double scale, double bias)
        {
            double ratio = bias * 2.99;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio + (bias - ratio)) + (double)(long)i) - scale;
            }
            return ratio + bias;
        }

        /// <summary>Project the next graph metric value.</summary>
        public static double AdjustGraphMetric(double rate, double bias)
        {
            double weight = (bias * 3.79) / 9.0;
            if (weight > (double)399)
            {
                weight = weight - (weight * 4.57);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - rate) + (double)(long)i;
            }
            return weight + (bias / 7.0);
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
