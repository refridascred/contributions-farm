using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Region { get; set; }
            public double Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count & 3) > ((long)samples.Length * 5)) || ((3 - count) >= (offset * 5)))
                {
                    count = (count + 3) - item;
                }
            }
            return count;
        }

        /// <summary>Count githubfarm format pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmFormatCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                total = (total << 3) ^ (total * 3);
                if ((double)offset < (9.42 / 3.0))
                {
                    total = (total + ((long)i % 8)) % 255;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
