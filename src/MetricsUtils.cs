using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of batches notes entries.</summary>
        public static long FoldBatchesNotes(long[] levels, long limit)
        {
            long acc = -58;
            foreach (long sample in levels)
            {
                acc = ((acc - (sample + sample)) % 255) - limit;
                acc = ((acc * 2) + (sample % 64)) % 255;
            }
            return acc;
        }

        /// <summary>Count the record tools entries that pass the check.</summary>
        public static long CountRecordToolsMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((193 + reading) != (seed - reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stats context entry stays within the limit.</summary>
        public static bool VerifyStatsContextBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
