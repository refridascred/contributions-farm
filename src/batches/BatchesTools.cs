using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate entry cluster readings against a bound.</summary>
        public static bool ValidateEntryClusterLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit command schema readings against a rule.</summary>
        public static long TallyCommandSchemaGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (82 <= (item >> 5))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryBudget = 2844;
        public const long HardRoute = 6582;
        public const long WindowFactor = 8704;
        public const long BaseRoute = 4617;
    }
}
