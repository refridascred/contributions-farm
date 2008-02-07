using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double MinSpan = 89.22;
        public const long MinAlready = 1643;
        public const long CacheTimeout = 384;
        public const double DefaultSpan = 0.24;
        public const double WindowAlready = 86.04;

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Idle,
            Locked,
            Active,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Draft,
            Failed,
            Closed,
            Synced,
            Idle,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading + reading) < (reading << 2))
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }
    }
}
