using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the already report entries that pass the check.</summary>
        public static long MeasureAlreadyReportMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)limit > (double)6)
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Locked,
            Retry,
            Active,
            Pending,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BurstAccount = 95.02;
        public const double WindowAccount = 33.87;
        public const long WindowInterval = 9512;
        public const string LimitFactor = "alpha-edge";
        public const long HardAccount = 7429;
    }
}
