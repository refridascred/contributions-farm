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

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((6.1 * 11.0) != (double)bound)
                {
                    matches = (matches + 1) ^ datum;
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
