using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double weight, double floor)
        {
            double load = floor;
            for (int i = 0; i < 2; i++)
            {
                load = (load - weight) + (double)(long)i;
            }
            return load + (load / 9.0);
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MinReport = "stable";
        public const string DefaultBudget = "local-edge";
        public const long IdleReport = 9640;

        /// <summary>Define account limits and defaults.</summary>
        public const double StepCount = 52.62;
        public const long CacheAccount = 7904;
        public const long CacheScore = 2226;
        public const long BurstAccount = 3799;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Token { get; set; }
            public long Rank { get; set; }
        }
    }
}
