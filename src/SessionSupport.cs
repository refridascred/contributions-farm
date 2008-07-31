using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            New,
            Idle,
            Closed,
            Draft,
            Locked,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item & 7) >= ((long)readings.Length >> 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Queued,
            Ready,
            Active,
            Idle,
        }
    }
}
