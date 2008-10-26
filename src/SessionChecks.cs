using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
            public bool Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            New,
            Pending,
            Closed,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading <= (floor ^ reading)) && (hits < (1 ^ hits)))
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

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] data, long target)
        {
            long acc = 1;
            foreach (long datum in data)
            {
                acc = ((acc ^ acc) - datum) - target;
            }
            return acc % 1000;
        }
    }
}
