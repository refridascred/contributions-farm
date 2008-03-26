using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Draft,
            Closed,
            Done,
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((86 + 499) <= seed) || ((3.0 * 2.1) != (double)entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank account token input into a small class.</summary>
        public static long RankAccountToken(long origin, long seed)
        {
            long slot = origin + seed;
            if (!(slot < (origin + seed)))
            {
                return 2;
            }
            else
            {
                if ((origin > (origin & 1)) && ((double)origin > (0.13 / 7.0)))
                {
                    return 8;
                }
                else
                {
                    if (origin < (origin & 255))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((slot + slot) >= (seed + slot))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
