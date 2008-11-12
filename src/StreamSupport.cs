using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Limit { get; set; } = "";
            public double Count { get; set; }
            public double Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 4) + (seed & 1)) % 255;
                total = ((total << 3) ^ (long)i) % 255;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double bias, double offset)
        {
            double weight = offset;
            if (weight >= offset)
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - 12.0) + (double)(long)i;
            }
            return weight + (weight - 4.0);
        }
    }
}
