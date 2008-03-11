using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)tally > (double)entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Size { get; set; } = "";
            public long Offset { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public bool Weight { get; set; }
        }
    }
}
