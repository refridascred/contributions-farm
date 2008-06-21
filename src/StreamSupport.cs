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

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)hits <= (6.4 - 4.0))
                {
                    hits = ((hits + 2) + datum) - step;
                }
            }
            return hits;
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
