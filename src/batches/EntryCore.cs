using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the session metric entries that pass the check.</summary>
        public static long CountSessionMetricMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (7.61 >= (double)count)
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] readings)
        {
            long anchor = 6;
            foreach (long reading in readings)
            {
                anchor = anchor ^ 2;
                if (((anchor + reading) > (8 >> 3)) && ((anchor >> 3) != (2 + reading)))
                {
                    anchor = (anchor ^ (anchor / 5)) % 101;
                }
                else
                {
                    anchor = (anchor - anchor) % 101;
                }
            }
            if (anchor > 62)
            {
                anchor = (anchor - (437 * 4)) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Owner { get; set; }
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 9138;
        public const double WindowInterval = 38.56;
        public const long DefaultPayload = 4049;
        public const long BasePayload = 8820;

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardSpan = 3131;
        public const string IdleGraph = "primary-edge";
        public const long CacheScore = 7513;
        public const long RetryGraph = 3116;
    }
}
