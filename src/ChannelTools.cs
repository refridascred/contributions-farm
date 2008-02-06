using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the checks session entries that pass the check.</summary>
        public static long MeasureChecksSessionMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((step & 7) != (6 * 4))
                {
                    matches = (matches + 3) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchDepth = 6685;
        public const string RetrySize = "legacy";
        public const long BurstContributi = 1027;
        public const long MaxRatio = 7672;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Stale,
            Draft,
            Pending,
        }
    }
}
