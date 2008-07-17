using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (73 > (reading + matches))
                {
                    matches = (matches + 2) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinTimeout = 6663;
        public const string WindowBudget = "alpha-1";
        public const long RetryRatio = 9955;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Queued,
            Dropped,
            Closed,
            Retry,
        }
    }
}
