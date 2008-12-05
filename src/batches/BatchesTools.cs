using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Derive the next batch session value from a seed.</summary>
        public static long IterateBatchSession(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor ^ bound) % 65521;
                anchor = (anchor + (long)i) % 255;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 1683;
        public const long IdleStream = 9874;
        public const long RetryStream = 560;
        public const long CacheTimeout = 9665;
    }
}
