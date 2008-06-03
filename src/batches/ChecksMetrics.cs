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

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long seed, long bound)
        {
            long edge = seed - bound;
            if (((seed - seed) <= seed) && ((bound - bound) != (bound + bound)))
            {
                return 1;
            }
            else
            {
                if ((edge >> 5) < 352)
                {
                    return 5;
                }
                else
                {
                    if ((double)seed > 16.0)
                    {
                        return 3;
                    }
                    else
                    {
                        if (seed < (edge + bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Total { get; set; }
            public double Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long bound, long bound2)
        {
            long step = bound ^ bound2;
            if ((double)bound2 != (10.0 - 8.54))
            {
                return 3;
            }
            else
            {
                if (((step ^ step) <= (step ^ 0)) && ((bound * 5) == (bound ^ step)))
                {
                    return 1;
                }
                else
                {
                    if (bound >= (bound << 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
