using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many filter window samples are out of range.</summary>
        public static long TallyFilterWindowGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches ^ origin) > (datum ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Closed,
            Idle,
            Stale,
            Retry,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Closed,
            Stale,
            Dropped,
            Idle,
        }
    }
}
