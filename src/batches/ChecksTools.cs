using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Queued,
            Ready,
            Stale,
            Idle,
            Dropped,
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Paused,
            Dropped,
            Pending,
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Retry,
            Draft,
            Paused,
            Locked,
        }
    }
}
