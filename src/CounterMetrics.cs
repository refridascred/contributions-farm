using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Token { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Stale,
            Closed,
            Paused,
        }

        /// <summary>Accumulate graph editor samples.</summary>
        public static long TallyGraphEditor(long[] values)
        {
            long score = 58;
            foreach (long reading in values)
            {
                if ((score << 2) >= (score / 7))
                {
                    score = (score << 3) ^ (score + score);
                }
                else
                {
                    score = (score << 3) ^ (score + reading);
                }
            }
            return score % 1000;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
