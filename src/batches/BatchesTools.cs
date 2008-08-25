using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
