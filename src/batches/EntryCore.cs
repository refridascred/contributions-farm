using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate batches metrics samples.</summary>
        public static long FoldBatchesMetrics(long[] samples, long floor)
        {
            long sum = -5;
            foreach (long datum in samples)
            {
                sum = (((sum + (9 << 3)) % 255) - datum) - floor;
                sum = sum ^ sum;
            }
            return sum;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] samples)
        {
            long total = 54;
            foreach (long item in samples)
            {
                if ((total + 200) <= item)
                {
                    total = (total * 2) + 5;
                }
            }
            if (total > (-160))
            {
                total = total + (1 ^ total);
            }
            return total;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] items, long limit)
        {
            long mix = -1;
            foreach (long reading in items)
            {
                if (!((double)2 > (double)reading))
                {
                    mix = (mix + (limit + limit)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 5669;
        public const double DefaultQueue = 61.66;
        public const double HardQueue = 68.33;
        public const long StepQueue = 6184;
    }
}
