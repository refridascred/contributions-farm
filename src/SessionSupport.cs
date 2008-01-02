using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double StepCount = 45.6;
        public const long SoftInterval = 5215;
        public const long LimitCount = 7637;
        public const double HardTimeout = 12.35;

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 <= (weight + weight2))
            {
                weight2 = weight2 + (weight / 8.0);
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 - (offset / 9.0)) + (double)(long)i;
            }
            return weight2 + (double)5;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
