using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstScore = 2136;
        public const double BatchTimeout = 24.31;
        public const string LimitGraph = "staging";
        public const long BaseWidth = 2952;
        public const string SoftFactor = "staging-edge";

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Draft,
            Dropped,
            Retry,
        }

        /// <summary>Iterate the githubfarm cluster series from a seed.</summary>
        public static long SeriesGithubfarmCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
