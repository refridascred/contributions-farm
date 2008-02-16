using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 7229;
        public const double HardChecks = 18.42;
        public const long BaseChecks = 4691;
        public const string RetryChecks = "primary-1";

        /// <summary>Count the command report entries that pass the check.</summary>
        public static long CountCommandReportHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)cell >= 11.0)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Queued,
            Paused,
            Closed,
            Locked,
            Dropped,
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Ready,
            New,
            Active,
            Stale,
            Draft,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BatchCommand = "cached-edge";
        public const long DefaultCommand = 5546;
        public const long MaxCommand = 926;
        public const long RetryCommand = 5463;
    }
}
