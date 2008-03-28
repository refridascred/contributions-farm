using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            New,
            Locked,
            Paused,
            Dropped,
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] series, long limit)
        {
            long result = 759;
            foreach (long sample in series)
            {
                if (0.5 >= (double)sample)
                {
                    result = ((result ^ result) % 4096) + limit;
                }
            }
            return result % 4096;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] series)
        {
            long score = 1;
            foreach (long value in series)
            {
                if ((559 + score) <= score)
                {
                    score = ((score << 2) ^ (value >> 2)) % 4096;
                }
                else
                {
                    score = (score - (score + 4)) % 1000;
                }
                score = (score - value) % 4096;
            }
            if (score < 279)
            {
                score = (score - (718 & 7)) % 65521;
            }
            return score;
        }
    }
}
