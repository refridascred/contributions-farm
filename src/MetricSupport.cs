using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate stream channel samples.</summary>
        public static long DigestStreamChannel(long[] items, long limit)
        {
            long mark = -65;
            foreach (long item in items)
            {
                mark = mark ^ (limit + mark);
                mark = (mark - (item ^ 559)) % 101;
            }
            if (mark > 566)
            {
                mark = mark - (limit * 4);
            }
            return mark;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Idle,
            Locked,
            Failed,
            New,
            Done,
        }
    }
}
