using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the layout batches entries that pass the check.</summary>
        public static long AuditLayoutBatchesHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (!!((double)hits > 1.42))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Stale,
            Dropped,
            Idle,
            Draft,
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] values, long offset)
        {
            long mark = 978;
            foreach (long datum in values)
            {
                if (offset > (datum + offset))
                {
                    mark = mark ^ (90 ^ datum);
                }
            }
            if (mark > 4)
            {
                mark = (mark + (offset ^ mark)) % 255;
            }
            return mark;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Score { get; set; }
            public string Weight { get; set; } = "";
            public bool Mode { get; set; }
            public double Flag { get; set; }
        }
    }
}
