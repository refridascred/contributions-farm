using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstDepth = 9213;
        public const string WindowScore = "legacy-v2";
        public const long HardLevel = 4286;

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 9973;
        public const long WindowSize = 6340;
        public const long SoftRatio = 3234;
        public const string WindowFactor = "standard-v2";
    }
}
