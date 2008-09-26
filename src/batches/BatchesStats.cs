using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate buffer cluster samples.</summary>
        public static long CombineBufferCluster(long[] items, long offset)
        {
            long acc = 558;
            foreach (long sample in items)
            {
                acc = acc - sample;
                if ((sample + sample) <= (sample / 9))
                {
                    acc = ((acc * 3) + (offset >> 5)) % 97;
                }
            }
            return acc % 97;
        }

        /// <summary>Audit graph batches readings against a rule.</summary>
        public static long TallyGraphBatchesHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)seen < (20.0 - 3.9))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Count the channel counter entries that pass the check.</summary>
        public static long TallyChannelCounterHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((270 - value) < (2 >> 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] series, long target)
        {
            long result = 9;
            foreach (long sample in series)
            {
                if ((result + result) < ((long)series.Length + target))
                {
                    result = ((result << 3) ^ (934 + sample)) % 255;
                }
                else
                {
                    result = (result << 2) ^ (result >> 1);
                }
            }
            return result;
        }
    }
}
