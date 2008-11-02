using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 > (rate + rate))
            {
                rate2 = rate2 + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 - rate2;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardLevel = 7844;
        public const long HardBatch = 1189;
        public const long SoftBatch = 914;
    }
}
