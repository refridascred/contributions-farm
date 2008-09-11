using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every checks entry entry stays within the limit.</summary>
        public static bool VerifyChecksEntryLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Pending,
            Failed,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowInterval = "stable-edge";
        public const string LimitTools = "fallback-v2";
        public const long RetryTools = 5779;
    }
}
