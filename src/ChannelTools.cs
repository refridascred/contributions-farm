using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long bound, long offset)
        {
            long span = bound + offset;
            if ((offset >> 5) == (span - 92))
            {
                return 3;
            }
            else
            {
                if (!((7 * 3) == (bound - bound)))
                {
                    return 8;
                }
                else
                {
                    if (!(bound >= (bound * 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((0.06 * 3.0) > (double)span)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Flag { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
