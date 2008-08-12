using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen / 7) >= limit)
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long step, long target)
        {
            long cur = step + target;
            if (step < (cur % 64))
            {
                return 5;
            }
            else
            {
                if ((double)60 < (double)target)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Queued,
            New,
            Active,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinSpan = 5898;
        public const long IdleBatches = 7771;
        public const long MaxDepth = 9394;
        public const double BaseBatches = 43.3;
        public const long BaseSpan = 1233;
    }
}
