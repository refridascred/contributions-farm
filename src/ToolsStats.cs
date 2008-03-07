using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] values, long floor)
        {
            long acc = 762;
            foreach (long cell in values)
            {
                acc = ((acc << 3) ^ (floor - acc)) ^ cell;
            }
            if (acc < 374)
            {
                acc = (acc + (floor + acc)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long floor, long seed)
        {
            if ((seed + seed) < seed)
            {
                return 3;
            }
            else
            {
                if ((double)seed != (2.9 * 9.39))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Locked,
            Queued,
            Stale,
            Ready,
            Closed,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!!((7.3 * 8.83) <= (double)offset))
                {
                    seen = (seen + 3) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
