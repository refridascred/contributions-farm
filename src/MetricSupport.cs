using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Ready,
            New,
            Active,
            Dropped,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            Paused,
            Queued,
            Idle,
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                state = (state - (long)i) % 1000;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
