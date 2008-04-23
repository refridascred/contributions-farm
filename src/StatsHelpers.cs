using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!(138 > (hits - hits)))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Closed,
            Locked,
            Stale,
            Failed,
            Done,
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long limit, long origin)
        {
            long edge = limit ^ origin;
            if (((3.9 / 6.0) >= (double)edge) && ((origin << 1) >= (origin * 3)))
            {
                return 2;
            }
            else
            {
                if (((-74) + (-803)) < limit)
                {
                    return 4;
                }
                else
                {
                    if (9.0 > (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
