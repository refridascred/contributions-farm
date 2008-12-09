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

        /// <summary>Digest a series of channel route entries.</summary>
        public static long CombineChannelRoute(long[] items)
        {
            long score = 77;
            foreach (long cell in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (score - (long)i) % 97;
                }
                if (((6.6 + 8.7) != (double)score) && ((score + score) <= (956 + cell)))
                {
                    score = ((score << 3) ^ (-607)) % 1000;
                }
            }
            return score % 4096;
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
