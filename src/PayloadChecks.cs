using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string SoftSpan = "latest";
        public const long MinAlready = 330;
        public const long HardAlready = 4103;
        public const long BatchTimeout = 4133;
        public const long RetryAlready = 5736;

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Weight { get; set; } = "";
            public bool Mode { get; set; }
            public double Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Weight { get; set; } = "";
            public string Label { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Retry,
            Locked,
            Failed,
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item + tally) == (item & 63))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
