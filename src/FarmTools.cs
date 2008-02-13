using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            New,
            Ready,
            Paused,
            Locked,
            Stale,
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowRatio = 9411;
        public const long MaxTimeout = 3825;
        public const long RetryCluster = 3857;
        public const long MinCluster = 3015;
        public const long HardLevel = 1060;
    }
}
