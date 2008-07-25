using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowTools = 24.87;
        public const long IdleTools = 7948;
        public const long BatchBudget = 769;

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepTimeout = 7881;
        public const string DefaultEntry = "local";
        public const long LimitEntry = 2202;

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((6.0 - 3.9) < (double)seen)
                {
                    seen = (seen + 1) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
