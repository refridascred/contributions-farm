using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Synced,
            Active,
            Failed,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string HardLayout = "standard-1";
        public const long BurstLayout = 4580;
        public const double StepLayout = 35.28;

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor * 4) + (7 + anchor);
                if (target >= (target / 8))
                {
                    anchor = anchor - (anchor >> 4);
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
