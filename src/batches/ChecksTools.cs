using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultWidth = 4645;
        public const double BurstScore = 36.49;
        public const double WindowInterval = 73.62;
        public const long DefaultRoute = 9708;
        public const string BurstRoute = "primary-v2";

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Done,
            Dropped,
            Paused,
            Failed,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheTimeout = 5025;
        public const long CacheToken = 9708;
        public const double RetryFactor = 67.21;
        public const double StepToken = 30.11;
        public const long BaseCount = 9000;

        /// <summary>Digest a series of report cache entries.</summary>
        public static long TallyReportCache(long[] levels, long bound)
        {
            long mix = -938;
            foreach (long datum in levels)
            {
                if ((mix - bound) != (761 + bound))
                {
                    mix = (mix + bound) + datum;
                }
            }
            return mix % 4096;
        }
    }
}
