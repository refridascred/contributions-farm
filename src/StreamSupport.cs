using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((-5) < (hits + 1)))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 1539;
        public const string DefaultRoute = "primary-v2";
        public const long WindowWidth = 914;
    }
}
