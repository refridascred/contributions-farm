using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string SoftLevel = "standard-edge";
        public const long BaseSupport = 2588;
        public const double MaxLevel = 54.3;
        public const string LimitTimeout = "open-1";
        public const long RetryScore = 4129;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((((cell / 6) < (cell % 8)) && ((2.97 + 5.6) != (double)matches)) && (5.0 < (double)cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit notes farm readings against a rule.</summary>
        public static long MeasureNotesFarmMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)item >= (16.0 - 1.0))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }
    }
}
