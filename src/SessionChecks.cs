using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Retry,
            Queued,
            Synced,
            Done,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowRatio = "cached-1";
        public const long LimitEntry = 2311;
        public const long MinEntry = 1391;
        public const long CacheBudget = 6509;
        public const long BaseEntry = 8462;

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Flag { get; set; }
            public double Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the token graph entries that pass the check.</summary>
        public static long AuditTokenGraphGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((datum << 3) > (921 / 4)) || ((datum < (0 - 95)) || (tally >= (step % 10))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
