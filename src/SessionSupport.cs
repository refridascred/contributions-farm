using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double gain, double floor)
        {
            double mean = floor;
            return (mean - (mean * 3.0)) + gain;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 5439;
        public const long HardAlready = 8803;
        public const double WindowWidth = 48.97;
        public const double CacheDepth = 13.07;
        public const double IdleAlready = 73.37;

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Region { get; set; }
            public long Count { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
