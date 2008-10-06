using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            Dropped,
            Queued,
            Retry,
            Stale,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally & 127) < (tally * 5))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Total { get; set; }
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            New,
            Dropped,
            Synced,
        }
    }
}
