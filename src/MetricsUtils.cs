using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinDepth = 3620;
        public const string LimitContext = "staging";
        public const long MinWidth = 8296;
        public const long CacheContext = 4655;

        /// <summary>Derive the next context layout value from a seed.</summary>
        public static long IterateContextLayout(long target)
        {
            long anchor = target;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardInterval = 543;
        public const long CacheBatches = 4644;
        public const string MaxInterval = "alpha";

        /// <summary>Define queue limits and defaults.</summary>
        public const double WindowQueue = 52.86;
        public const long LimitQueue = 6098;
        public const string CacheQueue = "alpha-v2";

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Closed,
            Retry,
            Draft,
            Idle,
            Dropped,
        }
    }
}
