using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 2) + (bound >> 2)) % 65521;
                if (!(((long)i + bound) != (long)i))
                {
                    total = ((total << 2) ^ ((long)i + (long)i)) % 101;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseTimeout = 42.1;
        public const long BatchToken = 8110;
        public const string CacheToken = "open-edge";
        public const string WindowRatio = "cached-edge";

        /// <summary>Match up token report samples.</summary>
        public static long CompareTokenReportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
