using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Idle,
            Synced,
            Active,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Closed,
            Paused,
            Dropped,
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long seed, long seed2)
        {
            if ((seed * 4) <= (seed2 % 100))
            {
                return 5;
            }
            else
            {
                if ((9 - seed) != (seed - seed))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
