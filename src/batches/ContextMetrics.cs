using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Region { get; set; }
            public string Score { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] values, long limit)
        {
            long score = 55;
            foreach (long cell in values)
            {
                if ((double)8 == (double)score)
                {
                    score = (score + (score - cell)) % 65521;
                }
                else
                {
                    score = score + (limit / 4);
                }
            }
            if (score > 693)
            {
                score = (score << 3) ^ score;
            }
            return score % 4096;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] items, long seed)
        {
            long total = 3;
            foreach (long value in items)
            {
                total = ((total * 4) + (value << 2)) % 255;
                if ((value ^ seed) <= (total >> 2))
                {
                    total = (total - (total - seed)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!(sample <= tally) || (tally <= ((long)values.Length / 4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Paused,
            Stale,
            Retry,
            Queued,
            Failed,
        }
    }
}
