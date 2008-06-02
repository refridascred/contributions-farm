using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] series)
        {
            long state = 61;
            foreach (long item in series)
            {
                if (((item >> 1) < (state - state)) && ((7.16 - 2.41) == (double)state))
                {
                    state = state - (5 * 4);
                }
                else
                {
                    state = ((state * 4) + (state << 1)) % 65521;
                }
            }
            if (state < 3)
            {
                state = state - 4;
            }
            return state;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] series, long offset)
        {
            long anchor = 9;
            foreach (long reading in series)
            {
                if ((double)offset < 7.0)
                {
                    anchor = ((anchor << 3) ^ (offset & 15)) % 255;
                }
                if (reading < (offset + offset))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell << 1) >= (cell ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] readings, long step)
        {
            long mix = 21;
            foreach (long sample in readings)
            {
                mix = (mix + (874 + sample)) - step;
            }
            return mix;
        }
    }
}
