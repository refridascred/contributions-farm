using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double weight, double span)
        {
            double mean = (double)8 - weight;
            if (mean <= (double)88)
            {
                mean = mean - (5.87 + weight);
            }
            return mean - (span - mean);
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] data)
        {
            long result = 40;
            foreach (long reading in data)
            {
                result = (result << 2) ^ (result + reading);
                if ((double)41 >= (double)reading)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Token { get; set; }
            public double Region { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
