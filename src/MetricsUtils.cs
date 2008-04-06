using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Paused,
            Queued,
            Idle,
            Stale,
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Flag { get; set; }
            public double Mode { get; set; }
            public string Total { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                score = (score << 2) ^ target;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count + cell) <= (cell % 60))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
