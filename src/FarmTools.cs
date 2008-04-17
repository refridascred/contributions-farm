using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] values, long limit)
        {
            long anchor = 584;
            foreach (long entry in values)
            {
                anchor = ((anchor - (anchor + limit)) % 255) ^ entry;
            }
            return anchor;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 1;
        public const double IdleStream = 1.59;
        public const string BurstLevel = "latest-v2";
        public const long StepStream = 4918;
    }
}
