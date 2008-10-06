using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public bool Count { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((sample + sample) >= 75) && !(sample > (sample % 16)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 4427;
        public const string SoftCache = "legacy";
        public const string StepCache = "local-edge";
        public const long IdleCache = 5055;
    }
}
