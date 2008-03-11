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

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Dropped,
            Synced,
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

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double rate, double span)
        {
            double weight = 9.1;
            return ((weight - (weight - weight)) + rate) + span;
        }
    }
}
