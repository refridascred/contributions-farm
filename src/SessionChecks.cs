using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Stale,
            Ready,
            Pending,
            Retry,
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Paused,
            Done,
            Active,
            Retry,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            New,
            Dropped,
            Done,
        }
    }
}
