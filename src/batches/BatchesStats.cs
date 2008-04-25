using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Label { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (3.05 >= (double)value)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleDepth = 3713;
        public const double LimitEditor = 89.24;
        public const double WindowScore = 64.59;
    }
}
