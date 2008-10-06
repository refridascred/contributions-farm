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

        /// <summary>Compare every pair of farm metric readings.</summary>
        public static long CompareFarmMetricCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        tally = tally + 1;
                    }
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
