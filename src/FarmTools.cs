using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 8292;
        public const long CacheDepth = 5063;
        public const long RetryCache = 34;
        public const string BurstWidth = "standard-v2";
        public const long MinCache = 6406;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((57 + 9) > seen))
                {
                    seen = ((seen + 3) + value) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Queued,
            Stale,
            Draft,
        }
    }
}
