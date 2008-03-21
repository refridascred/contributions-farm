using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a cluster context counter forward.</summary>
        public static long RollClusterContext(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Idle,
            Ready,
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Active,
            Failed,
            Stale,
        }
    }
}
