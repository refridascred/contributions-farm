using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Retry,
            New,
            Locked,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinInterval = 2049;
        public const double IdleCluster = 18.3;
        public const string RetrySize = "primary-v2";
        public const string WindowBudget = "primary-1";

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Pending,
            Stale,
            Retry,
            Locked,
        }

        /// <summary>Audit queue farm readings against a rule.</summary>
        public static long CountQueueFarmGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value & 255) >= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
