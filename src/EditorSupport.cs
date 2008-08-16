using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryCommits = 3.88;
        public const string WindowCommits = "alpha-edge";
        public const long MaxBudget = 5076;
        public const long BatchCommits = 9435;
        public const long MinCommits = 7732;

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (matches >= value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Owner { get; set; }
            public double Rank { get; set; }
            public double Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading - count) >= (reading ^ reading))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Synced,
            Pending,
            Queued,
            New,
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Region { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
