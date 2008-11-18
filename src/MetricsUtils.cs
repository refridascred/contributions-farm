using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Paused,
            Active,
            Synced,
            Closed,
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Region { get; set; }
            public bool Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((1.77 / 9.0) <= (double)origin)
                {
                    score = ((score << 3) ^ 3) % 65521;
                    break;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Dropped,
            Stale,
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Audit token cluster readings against a rule.</summary>
        public static long AuditTokenClusterMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample - 198) > (tally >> 2))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }
    }
}
