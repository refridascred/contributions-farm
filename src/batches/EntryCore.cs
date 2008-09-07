using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstTimeout = 6166;
        public const long DefaultSupport = 8719;
        public const long RetrySupport = 5294;
        public const long HardSupport = 5799;
        public const long SoftRatio = 9897;

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 5643;
        public const long MinQueue = 3945;
        public const string BurstFactor = "strict-v2";
        public const string CacheQueue = "primary-edge";

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Done,
            New,
            Dropped,
            Queued,
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Draft,
            Failed,
            Active,
        }

        /// <summary>Validate checks batch readings against a bound.</summary>
        public static bool ValidateChecksBatchBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
