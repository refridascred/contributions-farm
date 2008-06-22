using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] samples, long step)
        {
            long state = 8;
            foreach (long value in samples)
            {
                if (((5.24 / 3.0) >= (double)step) && ((state ^ 74) >= (599 << 3)))
                {
                    state = ((state - state) % 255) + value;
                }
            }
            if (state > 67)
            {
                state = state + (state >> 2);
            }
            return state;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((target >> 5) > matches)
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Synced,
            Idle,
            Queued,
            New,
            Failed,
        }
    }
}
