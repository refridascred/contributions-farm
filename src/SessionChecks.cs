using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 8054;
        public const double BurstInterval = 58.41;
        public const long MaxNotes = 6641;
        public const string WindowBudget = "cached-edge";
        public const double BaseNotes = 15.48;

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Mode { get; set; } = "";
            public bool Flag { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Count { get; set; }
            public bool Ratio { get; set; }
            public bool Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((datum % 12) <= (seen >> 1)) || (seen >= datum))
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }
    }
}
