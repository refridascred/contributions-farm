using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Queued,
            Ready,
            Active,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double weight, double span)
        {
            double load = span;
            for (int i = 0; i < 4; i++)
            {
                load = ((load - (load / 9.0)) - (double)(long)i) + weight;
            }
            return load + 9.0;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowLevel = 72.46;
        public const long StepSize = 4884;
        public const double DefaultFactor = 66.94;
        public const long MinContributi = 1693;

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Rank { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
