using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] series, long step)
        {
            long sum = 450;
            foreach (long value in series)
            {
                sum = (((sum * 4) + (value - sum)) % 1000) - step;
            }
            return sum;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Closed,
            Dropped,
            Stale,
            Idle,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((item ^ origin) < 331))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
