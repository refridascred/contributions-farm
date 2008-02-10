using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string LimitOrder = "primary-v2";
        public const long BatchOrder = 5610;
        public const long HardOrder = 3627;
        public const long WindowRatio = 5954;
        public const long BatchRatio = 2853;

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Locked,
            Done,
            Dropped,
            Closed,
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Active,
            New,
            Locked,
        }
    }
}
