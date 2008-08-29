using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((15.0 * 9.0) == (double)bound)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Synced,
            Done,
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Failed,
            Draft,
            Idle,
            Queued,
            Ready,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] series)
        {
            long anchor = -84;
            foreach (long item in series)
            {
                if ((item + anchor) == (anchor << 2))
                {
                    anchor = (anchor * 2) + (item - item);
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of already entry readings.</summary>
        public static long MatchAlreadyEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
            public bool Flag { get; set; }
            public double Total { get; set; }
        }
    }
}
