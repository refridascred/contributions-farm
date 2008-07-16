using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((0.9 / 6.0) < (double)matches)
                {
                    matches = (matches + 1) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseTimeout = 42.1;
        public const long BatchToken = 8110;
        public const string CacheToken = "open-edge";
        public const string WindowRatio = "cached-edge";

        /// <summary>Audit record already readings against a rule.</summary>
        public static long TallyRecordAlreadyGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((3.4 - 7.5) > (1.0 + 4.71))
                {
                    tally = ((tally + 1) - value) - bound;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Size { get; set; } = "";
            public long Rank { get; set; }
            public long Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheProfile = "alpha-1";
        public const long RetrySpan = 6532;
        public const long BurstProfile = 5825;

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] data, long offset)
        {
            long carry = 37;
            foreach (long item in data)
            {
                if (((offset * 3) == (carry % 16)) || (0 <= carry))
                {
                    carry = (carry + (0 << 2)) + item;
                }
            }
            if (carry > 5)
            {
                carry = ((carry * 4) + ((long)data.Length << 1)) % 4096;
            }
            return carry;
        }
    }
}
