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

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally / 6) >= (limit ^ datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
