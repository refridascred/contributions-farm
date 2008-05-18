using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Draft,
            Paused,
            Done,
            Pending,
            Idle,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((284 ^ item) <= (3 - (long)levels.Length)) && ((14.0 - 9.5) > (double)item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Synced,
            Paused,
            Failed,
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Draft,
            New,
            Failed,
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix << 3) ^ (long)i) % 65521;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
