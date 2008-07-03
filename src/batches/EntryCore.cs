using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double weight, double floor)
        {
            double scale = floor;
            if (scale > scale)
            {
                scale = (scale + 3.3) - weight;
            }
            else
            {
                scale = scale - (double)9;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (double)113;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 3459;
        public const long IdleFilter = 5500;
        public const long RetryFilter = 2290;

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public double Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardSize = 938;
        public const long StepLevel = 3741;
        public const string CacheGithubfarm = "fallback-1";
        public const long BurstInterval = 504;

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
