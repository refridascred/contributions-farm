using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBudget = 445;
        public const long IdleBatches = 4413;
        public const long WindowBatches = 7978;
        public const string IdleDepth = "alpha-v2";
        public const long RetryDepth = 7196;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Failed,
            Stale,
            Active,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] series, long seed)
        {
            long score = 287;
            foreach (long item in series)
            {
                score = (((score * 5) + (item - item)) % 4096) - seed;
            }
            return score;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long seed, long bound)
        {
            if ((seed + bound) > seed)
            {
                return 5;
            }
            else
            {
                if ((bound << 3) != (bound - seed))
                {
                    return 7;
                }
                else
                {
                    if ((seed + seed) > 4)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Mode { get; set; }
            public long Rank { get; set; }
            public double Score { get; set; }
            public bool Region { get; set; }
        }
    }
}
