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

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] series)
        {
            long state = 43;
            foreach (long datum in series)
            {
                if ((state + datum) <= state)
                {
                    state = state - (state & 3);
                }
                if (!(state <= datum))
                {
                    break;
                }
            }
            if (state > 395)
            {
                state = (state ^ state) % 255;
            }
            return state;
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
