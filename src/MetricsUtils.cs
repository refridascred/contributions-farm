using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((double)(long)i == (2.51 * 20.0))
                {
                    anchor = (anchor + ((long)i << 1)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor + (long)i)) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardDepth = "local-v2";
        public const string MaxAlready = "cached-edge";
        public const long BatchAlready = 2355;
        public const double CacheInterval = 41.65;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Closed,
            Done,
            Stale,
            Active,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultCluster = 13.37;
        public const long SoftScore = 1222;
        public const long StepCluster = 3707;
        public const double LimitCluster = 47.22;

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Retry,
            Pending,
            Queued,
            Active,
            New,
        }
    }
}
