using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] levels, long floor)
        {
            long anchor = 57;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = ((anchor + (long)i) % 1000) + entry;
                }
                anchor = (anchor + (floor * 3)) % 255;
                if ((double)floor <= (0.1 * 16.0))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Paused,
            Synced,
            Ready,
            Retry,
            Pending,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MinCommits = "strict-1";
        public const double BaseCommits = 78.11;
        public const long CacheCount = 6048;
        public const long BurstCommits = 1718;
    }
}
