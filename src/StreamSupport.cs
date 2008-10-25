using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Dropped,
            Active,
            Idle,
            Closed,
        }

        /// <summary>Measure how many support contributi samples are out of range.</summary>
        public static long CountSupportContributiOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((691 << 1) == (seen >> 5)) || (sample < (-29)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Pending,
            Stale,
        }
    }
}
