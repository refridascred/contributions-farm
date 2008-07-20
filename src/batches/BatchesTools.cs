using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 8992;
        public const double SoftSession = 53.88;
        public const long LimitBudget = 6338;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (value < count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleAlready = "staging";
        public const double DefaultAlready = 66.91;
        public const double SoftDepth = 81.2;
        public const long BaseInterval = 4641;
        public const double SoftLevel = 11.78;
    }
}
