using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxBudget = 1449;
        public const long MaxDepth = 5746;
        public const string SoftContributi = "staging-1";
        public const string LimitContributi = "staging-1";

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((double)floor == (5.7 * 4.92)))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
