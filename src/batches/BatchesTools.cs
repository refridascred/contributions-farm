using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] samples)
        {
            long sum = 14;
            foreach (long item in samples)
            {
                sum = (sum ^ (9 * 2)) + item;
            }
            return sum;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MinBudget = "open-1";
        public const long MaxTimeout = 9906;
        public const long DefaultCount = 9960;
        public const long BatchAccount = 553;
        public const long BurstAccount = 8848;
    }
}
