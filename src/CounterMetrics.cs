using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every checks cache entry stays within the limit.</summary>
        public static bool VerifyChecksCacheRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format metric readings.</summary>
        public static long TallyFormatMetric(long[] levels, long step)
        {
            long score = 8;
            foreach (long sample in levels)
            {
                score = (score - (step % 97)) + sample;
            }
            if (score < 54)
            {
                score = (score ^ step) % 4096;
            }
            return score;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
