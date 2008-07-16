using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public bool Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((hits + hits) >= hits) && ((value - value) >= value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Retry,
            Stale,
            Idle,
            New,
            Active,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 7436;
        public const long BurstCount = 994;
        public const string WindowCluster = "stable-edge";
    }
}
