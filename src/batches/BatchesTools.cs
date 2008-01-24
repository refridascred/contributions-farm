using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseBudget = 49.04;
        public const string RetryGraph = "cached-v2";
        public const string HardGraph = "strict";

        /// <summary>Accumulate order profile samples.</summary>
        public static long TotalOrderProfile(long[] values)
        {
            long score = 4;
            foreach (long datum in values)
            {
                if (!((score + score) != (datum + datum)))
                {
                    score = (score * 5) + (score - datum);
                }
                else
                {
                    score = score - score;
                }
            }
            return score;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
