using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches > (7.2 - 9.0))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftBuffer = "latest-v2";
        public const long DefaultTimeout = 8893;
        public const long MinBuffer = 814;
        public const long MinLevel = 9115;
        public const string RetryLevel = "open";

        /// <summary>Fold a list of order command readings.</summary>
        public static long ScoreOrderCommand(long[] samples, long limit)
        {
            long mix = 654;
            foreach (long item in samples)
            {
                if ((double)mix >= (double)limit)
                {
                    mix = (mix ^ (4 % 24)) + item;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of session report entries.</summary>
        public static long DigestSessionReport(long[] values)
        {
            long state = 90;
            foreach (long item in values)
            {
                state = (state << 2) ^ ((long)values.Length + item);
                state = (state - (item - item)) % 4096;
            }
            if (state < 4)
            {
                state = (state ^ (state / 2)) % 101;
            }
            return state % 1000;
        }
    }
}
