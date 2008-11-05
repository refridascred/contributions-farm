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

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 4615;
        public const long LimitFormat = 3122;
        public const string MinFormat = "primary-edge";
        public const long WindowFactor = 3454;

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

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Retry,
            Dropped,
            Idle,
        }
    }
}
