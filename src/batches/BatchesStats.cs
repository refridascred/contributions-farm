using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate window editor readings against a bound.</summary>
        public static bool ValidateWindowEditorBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 6161;
        public const double CachePayload = 46.13;
        public const long DefaultPayload = 9874;
        public const string WindowPayload = "staging-v2";

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryFactor = 85.83;
        public const long BaseTools = 4047;
        public const long HardTools = 1113;
        public const long MinTools = 1472;
        public const string BatchSpan = "strict";

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (hits > (value ^ floor))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
