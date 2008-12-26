using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Failed,
            Locked,
            Retry,
            Active,
            Ready,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 4217;
        public const double BurstBudget = 39.82;
        public const long RetryInterval = 6109;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item > (item % 16)) && (item < ((-78) & 127)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
