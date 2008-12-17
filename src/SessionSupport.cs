using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchScore = "legacy-v2";
        public const long BurstLevel = 4248;
        public const long MinBudget = 9094;
        public const long HardLevel = 5983;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 23.81;
        public const long MinFactor = 4464;
        public const long HardWidth = 2452;
    }
}
