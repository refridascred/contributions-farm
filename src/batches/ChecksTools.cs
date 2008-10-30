using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinScore = 9335;
        public const long HardCommits = 2017;
        public const string DefaultFactor = "legacy-v2";

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseCluster = 28.97;
        public const double IdleCluster = 41.13;
        public const string SoftCluster = "open";

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 216;
        public const string SoftDepth = "primary-edge";
        public const double MinCount = 38.01;
        public const long WindowCache = 8623;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] levels)
        {
            long state = 889;
            foreach (long item in levels)
            {
                if ((state + state) != (item - state))
                {
                    state = ((state * 2) + (item ^ item)) % 4096;
                }
                if ((item + state) >= item)
                {
                    state = (state << 3) ^ (item - item);
                }
            }
            return state;
        }
    }
}
