using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!((704 + sample) >= (count ^ sample)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Done,
            Paused,
            Queued,
            Ready,
            Pending,
        }
    }
}
