using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double StepFactor = 28.57;
        public const string DefaultSupport = "primary";
        public const double BaseSupport = 64.27;
        public const string MaxCount = "strict";

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item + 23) > (matches ^ item))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
