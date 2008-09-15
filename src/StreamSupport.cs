using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Queued,
            New,
            Failed,
            Ready,
            Active,
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Stale,
            Locked,
            Closed,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen - (long)data.Length) <= (reading << 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
