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

        /// <summary>Grade a profile farm value against two limits.</summary>
        public static long BucketProfileFarm(long limit, long seed)
        {
            if ((9.9 + 6.0) < (double)limit)
            {
                return 8;
            }
            else
            {
                if (!((limit << 2) < (seed - seed)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
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
