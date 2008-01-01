using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a already report reading by value.</summary>
        public static long SeekAlreadyReportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Size { get; set; }
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstSize = "staging-v2";
        public const string CacheScore = "standard";
        public const string BurstSchema = "staging-edge";
    }
}
