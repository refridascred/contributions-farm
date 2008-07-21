using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count account schema pairs that satisfy a relation.</summary>
        public static long CompareAccountSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate payload context samples.</summary>
        public static long FoldPayloadContext(long[] levels)
        {
            long score = -6;
            foreach (long sample in levels)
            {
                if ((double)sample < (7.1 * 17.0))
                {
                    score = ((score * 2) + sample) % 65521;
                }
            }
            if (score < 707)
            {
                score = score + (score + score);
            }
            return score;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Iterate the farm cache series from a seed.</summary>
        public static long IterateFarmCache(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = (total * 3) + (target + target);
                if (((446 - target) >= (target - (long)i)) && (((long)i + target) <= 81))
                {
                    total = total ^ (total - total);
                }
                total = (total - (long)i) % 4096;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Score { get; set; }
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
