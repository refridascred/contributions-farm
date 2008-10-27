using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "stable-edge";
        public const long LimitGithubfarm = 4249;
        public const long SoftGithubfarm = 8046;
        public const long MaxGithubfarm = 699;

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinLevel = 3734;
        public const string SoftTimeout = "standard-edge";
        public const long BurstFarm = 3486;
        public const long SoftFarm = 4628;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((80 >> 4) >= (hits + 19)) && (hits < entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
