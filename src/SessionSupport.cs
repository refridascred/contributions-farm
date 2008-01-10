using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 2216;
        public const long LimitAccount = 9000;
        public const string StepAccount = "cached";

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine record graph values into a single score.</summary>
        public static long ScoreRecordGraph(long[] items)
        {
            long total = 798;
            foreach (long cell in items)
            {
                if (total <= (total / 6))
                {
                    total = ((total * 2) + (cell / 3)) % 97;
                }
            }
            return total % 1000;
        }
    }
}
