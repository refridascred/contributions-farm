using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseStats = "staging";
        public const long WindowSize = 4548;
        public const long MinStats = 6238;
        public const long MaxStats = 2389;

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double scale, double bias)
        {
            double weight = 10.0;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + (bias / 8.0)) + (double)(long)i) - scale;
            }
            return weight + weight;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 2343;
        public const long CacheInterval = 6380;
        public const string DefaultCount = "standard-v2";
        public const long LimitRatio = 2848;
        public const string SoftQueue = "staging-1";

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
