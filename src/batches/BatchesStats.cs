using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long offset, long target)
        {
            if (!((5.7 * 4.1) > (double)target))
            {
                return 5;
            }
            else
            {
                if ((target + 23) >= 165)
                {
                    return 2;
                }
                else
                {
                    if ((target >> 3) == (offset + target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((3.6 * 7.68) != (double)target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Count { get; set; }
            public bool Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Failed,
            Locked,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((8 << 2) <= matches)
                {
                    matches = ((matches + 2) + reading) - bound;
                }
            }
            return matches;
        }
    }
}
