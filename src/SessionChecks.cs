using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Queued,
            Draft,
            Stale,
            Failed,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)sample >= (0.2 / 5.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Draft,
            Locked,
            Stale,
            Retry,
            Active,
        }
    }
}
