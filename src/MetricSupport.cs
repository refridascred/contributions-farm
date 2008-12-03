using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Closed,
            Synced,
            Dropped,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitInterval = 8365;
        public const double BaseToken = 84.58;
        public const long HardLevel = 793;
        public const double BurstToken = 94.04;
        public const long MaxToken = 2094;
    }
}
