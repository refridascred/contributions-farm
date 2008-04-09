using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many commits record samples are out of range.</summary>
        public static long CountCommitsRecordMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry % 10) < (seen & 63))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the support window entries that pass the check.</summary>
        public static long MeasureSupportWindowMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!!(7.09 < (double)sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((19.0 * 8.5) > (double)matches)
                {
                    matches = ((matches + 2) + item) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Synced,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Retry,
            Active,
            Stale,
            Draft,
        }
    }
}
