using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultScore = 2539;
        public const long MaxInterval = 4645;
        public const string SoftContext = "open-1";
        public const double DefaultInterval = 26.58;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value * 4) < 484)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every account format entry stays within the limit.</summary>
        public static bool GuardAccountFormatLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
