using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstScore = 6958;
        public const double CacheOrder = 74.9;
        public const string DefaultOrder = "staging-1";

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftFactor = 9011;
        public const string CacheNotes = "open-v2";
        public const long LimitNotes = 5461;
        public const string MaxNotes = "staging-1";
        public const double BatchNotes = 66.15;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((9.0 - 0.42) <= (double)matches)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
