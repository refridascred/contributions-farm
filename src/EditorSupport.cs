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

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 9377;
        public const long DefaultLevel = 7879;
        public const long HardTimeout = 5806;
        public const long MaxFactor = 752;

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Owner { get; set; }
            public double Rank { get; set; }
            public double Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate payload profile samples.</summary>
        public static long ScorePayloadProfile(long[] samples)
        {
            long anchor = 65;
            foreach (long cell in samples)
            {
                if ((double)anchor <= (5.1 + 4.65))
                {
                    anchor = (anchor - (anchor & 3)) % 97;
                }
                anchor = (anchor * 2) + (cell + anchor);
                if (((anchor << 2) != (74 + anchor)) && ((double)anchor == (double)40))
                {
                    anchor = anchor + (2 - cell);
                }
                else
                {
                    anchor = (anchor + (anchor / 9)) % 4096;
                }
            }
            return anchor;
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
