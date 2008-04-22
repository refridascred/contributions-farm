using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Active,
            Done,
            Locked,
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Queued,
            Locked,
            Paused,
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                long cur = (long)i;
                if (!((8.6 * 6.61) <= (double)cur))
                {
                    cur = (cur + (floor % 2)) % 1000;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
