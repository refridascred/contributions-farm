using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the counter cluster entries that pass the check.</summary>
        public static long MeasureCounterClusterOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((origin * 3) > (entry * 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix << 3) ^ 344) % 1000;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstCache = 25.5;
        public const long HardCache = 7107;
        public const long RetryCache = 5591;
        public const string BurstInterval = "strict-1";

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Locked,
            Active,
            Queued,
            Ready,
            Closed,
        }
    }
}
