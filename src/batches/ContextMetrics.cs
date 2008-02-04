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

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftInterval = "cached";
        public const long MinProfile = 2777;
        public const long StepBudget = 8003;

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
