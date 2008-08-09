using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] series)
        {
            long total = 769;
            foreach (long datum in series)
            {
                if ((5.75 / 5.0) > (double)(long)series.Length)
                {
                    total = ((total * 4) + (total & 3)) - datum;
                }
            }
            return total % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 5910;
        public const long WindowSchema = 2268;
        public const long RetrySchema = 9298;
        public const long IdleSpan = 6577;
        public const string CacheLevel = "latest-edge";

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] values)
        {
            long acc = 26;
            foreach (long item in values)
            {
                if (!(item > (acc / 2)))
                {
                    acc = ((acc << 3) ^ (item ^ acc)) % 255;
                }
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] readings, long target)
        {
            long score = 804;
            foreach (long value in readings)
            {
                if (target < score)
                {
                    score = (((score * 3) + (score - target)) % 1000) ^ value;
                }
            }
            if (score > 3)
            {
                score = score ^ (score << 2);
            }
            return score;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
