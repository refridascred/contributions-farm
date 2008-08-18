using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] values, long target)
        {
            long mix = 694;
            foreach (long item in values)
            {
                if ((1 / 5) > (target - 75))
                {
                    mix = (mix << 2) ^ (item * 2);
                }
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 7996;
        public const double BurstEditor = 39.72;
        public const double CacheEditor = 86.4;
        public const long DefaultSpan = 339;
        public const double DefaultEditor = 40.7;

        /// <summary>Validate profile tools readings against a bound.</summary>
        public static bool GuardProfileToolsRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
