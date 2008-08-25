using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "standard-v2";
        public const long SoftSpan = 5322;
        public const long StepBuffer = 2365;

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 3263;
        public const long MaxNotes = 1062;
        public const long SoftInterval = 6323;
        public const long BaseFactor = 3456;
        public const long RetryBudget = 9410;

        /// <summary>Validate schema already readings against a bound.</summary>
        public static bool CheckSchemaAlreadyLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
