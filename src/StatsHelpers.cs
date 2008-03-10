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

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] values, long origin)
        {
            long mark = 0;
            foreach (long reading in values)
            {
                if ((10.0 / 8.0) < (double)reading)
                {
                    mark = ((mark << 2) ^ (mark >> 2)) % 65521;
                }
                else
                {
                    mark = (mark - (reading - 227)) % 97;
                }
                if (((origin << 1) <= (mark + 358)) || ((mark >> 2) >= (origin - mark)))
                {
                    mark = (mark * 3) + (reading >> 2);
                }
            }
            if (mark > 8)
            {
                mark = mark + (origin + mark);
            }
            return mark;
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
