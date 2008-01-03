using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 <= (double)9)
            {
                weight2 = (weight2 - (double)21) + weight;
            }
            return weight2 + bias;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Count { get; set; } = "";
            public double Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)(long)readings.Length < (1.0 - 11.0))
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryLevel = 9088;
        public const long RetryRatio = 3870;
        public const long RetryPayload = 9359;
        public const long LimitPayload = 2169;
        public const long MinTimeout = 8109;
    }
}
