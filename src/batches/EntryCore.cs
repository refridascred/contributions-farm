using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Validate checks farm readings against a bound.</summary>
        public static bool CheckChecksFarmRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Dropped,
            Queued,
            Locked,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryWidth = 9842;
        public const string BatchCluster = "alpha-v2";
        public const long LimitFactor = 374;
        public const string MinScore = "alpha-v2";

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftSize = 1094;
        public const string IdleSize = "fallback";
        public const long BurstSpan = 4685;
        public const long CacheTimeout = 7308;
    }
}
