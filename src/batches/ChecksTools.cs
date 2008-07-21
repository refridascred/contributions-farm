using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + 95) != (9 % 10))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Queued,
            Stale,
            Draft,
            Failed,
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Active,
            Idle,
            Ready,
            Done,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Closed,
            Queued,
            Idle,
        }
    }
}
