using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Synced,
            Draft,
            Queued,
            Stale,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Stale,
            Pending,
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long seed)
        {
            long result = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((seed + result) <= (result >> 1))
                {
                    break;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
