using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string MaxBudget = "standard-edge";
        public const long DefaultCount = 5900;
        public const long BaseSpan = 8383;

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Token { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double gain, double span)
        {
            double drift = span;
            if (drift >= gain)
            {
                drift = drift - (drift + gain);
            }
            else
            {
                drift = drift + span;
            }
            return drift + (double)8;
        }
    }
}
