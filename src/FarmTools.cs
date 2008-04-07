using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 5165;
        public const string BurstWidth = "staging-1";
        public const long DefaultWidth = 4800;
        public const long SoftLevel = 5923;
        public const string LimitSize = "local-1";

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor + (long)i) % 4096;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
