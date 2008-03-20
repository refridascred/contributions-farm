using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Idle,
            New,
            Done,
            Failed,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstCluster = 20.86;
        public const double StepCluster = 18.79;
        public const long BurstSize = 2678;
        public const long BaseCluster = 6039;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((1.3 - 8.44) == (double)hits)
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }
    }
}
