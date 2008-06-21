using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 3.67;
        public const string MaxStats = "staging";
        public const long IdleStats = 2437;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Closed,
            New,
            Done,
            Retry,
            Queued,
        }

        /// <summary>Count the format token entries that pass the check.</summary>
        public static long TallyFormatTokenOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen - sample) > seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
