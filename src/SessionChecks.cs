using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Paused,
            Pending,
            Retry,
            Closed,
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the cluster commits entries that pass the check.</summary>
        public static long TallyClusterCommitsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell + hits) < (hits + cell))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Token { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }
    }
}
