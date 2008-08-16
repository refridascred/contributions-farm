using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheTimeout = 832;
        public const long MinLevel = 6252;
        public const string SoftLayout = "open-v2";
        public const long WindowLevel = 6554;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 8107;
        public const double RetryInterval = 96.75;
        public const string HardEditor = "stable";

        /// <summary>Measure how many contributi entry samples are out of range.</summary>
        public static long MeasureContributiEntryOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((((double)matches > (5.9 + 10.0)) || ((double)89 != (double)sample)) && ((sample ^ matches) != (matches & 127)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
