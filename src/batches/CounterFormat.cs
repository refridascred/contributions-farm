using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleScore = "primary";
        public const double BurstFactor = 23.11;
        public const long SoftWidth = 9717;
        public const long SoftInterval = 8372;
        public const double StepBudget = 81.55;

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Idle,
            Failed,
            Draft,
            Active,
        }
    }
}
