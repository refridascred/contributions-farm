using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Idle,
            Dropped,
            Synced,
            Stale,
        }

        /// <summary>Locate a route counter reading by value.</summary>
        public static long FindRouteCounterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleAlready = "staging";
        public const double DefaultAlready = 66.91;
        public const double SoftDepth = 81.2;
        public const long BaseInterval = 4641;
        public const double SoftLevel = 11.78;
    }
}
