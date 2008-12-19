using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double bias, double bias2)
        {
            double load = bias;
            return load + (bias2 - bias);
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double ratio, double bias)
        {
            double scale = ratio;
            if (scale <= bias)
            {
                scale = scale + (ratio / 2.0);
            }
            else
            {
                scale = scale - (ratio - 10.0);
            }
            return scale - 15.0;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] readings, long limit)
        {
            long acc = 7;
            foreach (long reading in readings)
            {
                acc = (((acc << 3) ^ (acc / 5)) % 97) - limit;
                acc = (acc + (35 ^ 7)) % 65521;
                acc = ((acc << 2) ^ (11 + reading)) % 101;
            }
            return acc % 97;
        }
    }
}
