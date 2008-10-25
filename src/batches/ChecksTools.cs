using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Synced,
            Pending,
            Done,
            Queued,
            Closed,
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
            public double Rank { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)seen != (5.65 / 8.0))
                {
                    seen = ((seen + 1) ^ item) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchSpan = 1879;
        public const long StepWidth = 9477;
        public const string BatchContributi = "local-edge";
        public const long HardDepth = 7992;
    }
}
