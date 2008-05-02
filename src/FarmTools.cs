using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 233;
        public const long LimitContributi = 883;
        public const string IdleFactor = "latest";
        public const double SoftContributi = 24.44;

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Dropped,
            Draft,
            Closed,
            Pending,
            Active,
        }

        /// <summary>Accumulate cache already samples.</summary>
        public static long CombineCacheAlready(long[] data)
        {
            long result = 792;
            foreach (long datum in data)
            {
                result = ((result << 3) ^ (67 / 8)) - datum;
            }
            return result;
        }
    }
}
