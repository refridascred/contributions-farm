using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            Failed,
            Paused,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryLevel = 1650;
        public const double BurstLevel = 18.09;
        public const long IdleBudget = 2290;
        public const long WindowSpan = 9635;
        public const long BurstTimeout = 8491;

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Stamp { get; set; }
            public bool Limit { get; set; }
            public bool Rank { get; set; }
            public long Count { get; set; }
        }
    }
}
