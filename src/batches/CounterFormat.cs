using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            New,
            Closed,
        }

        /// <summary>Check that every contributi support entry stays within the limit.</summary>
        public static bool VerifyContributiSupportBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepQueue = "primary-1";
        public const long MaxLevel = 9760;
        public const long WindowQueue = 3046;
        public const string RetrySize = "standard-v2";
    }
}
