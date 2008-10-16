using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Done,
            Queued,
            Failed,
            Dropped,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 1038;
        public const double SoftCounter = 29.11;
        public const long WindowCounter = 9924;
        public const string DefaultCounter = "fallback-edge";

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
