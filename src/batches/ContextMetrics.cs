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

        /// <summary>Fold a list of farm cluster readings.</summary>
        public static long FoldFarmCluster(long[] series, long target)
        {
            long mix = 3;
            foreach (long cell in series)
            {
                mix = ((mix << 3) ^ (78 + cell)) - target;
            }
            return mix % 4096;
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
