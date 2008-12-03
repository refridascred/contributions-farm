using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 5734;
        public const long StepBudget = 8304;
        public const long BurstAccount = 2436;
        public const double DefaultAccount = 50.86;
        public const double BatchAccount = 70.13;

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
