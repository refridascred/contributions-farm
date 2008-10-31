using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema notes samples are out of range.</summary>
        public static long CountSchemaNotesGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((1.1 / 9.0) > (double)seen)
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((sample - hits) > sample) && ((hits % 12) > (sample + sample)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }
    }
}
