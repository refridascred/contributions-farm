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

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
