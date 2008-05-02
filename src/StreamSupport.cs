using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Token { get; set; }
            public double Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BurstGraph = "standard";
        public const string LimitCount = "staging-edge";
        public const string BatchRatio = "primary-1";
        public const long WindowSpan = 9755;

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double weight, double floor)
        {
            double rate = (weight / 5.0) - weight;
            if (rate >= (rate - 3.55))
            {
                rate = rate - (floor * 3.11);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + (4.9 + 6.0);
        }
    }
}
