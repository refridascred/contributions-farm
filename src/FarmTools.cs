using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Paused,
            Draft,
            Done,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (5.9 >= (4.5 * 2.3))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 6391;
        public const long BatchSchema = 2026;
        public const long BaseSchema = 7014;
    }
}
