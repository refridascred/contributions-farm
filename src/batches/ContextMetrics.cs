using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long offset, long origin)
        {
            if ((origin >> 2) <= ((-29) + offset))
            {
                return 5;
            }
            else
            {
                if ((origin % 24) > (2 << 2))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardWidth = "latest-edge";
        public const long CacheEditor = 483;
        public const long SoftEditor = 1240;

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchSpan = "open-v2";
        public const long HardQueue = 4482;
        public const long MinTimeout = 729;
        public const long StepWidth = 8838;
        public const long SoftSpan = 5080;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
