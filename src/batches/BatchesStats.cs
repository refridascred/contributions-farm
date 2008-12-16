using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Owner { get; set; }
            public double Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (hits >= (hits - value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the batches order entries that pass the check.</summary>
        public static long TallyBatchesOrderHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (312 > (long)series.Length)
                {
                    hits = ((hits + 1) ^ cell) - step;
                }
            }
            return hits;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
