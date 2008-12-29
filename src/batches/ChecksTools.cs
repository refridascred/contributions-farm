using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstPayload = "standard";
        public const double DefaultScore = 76.35;
        public const long DefaultSpan = 9507;
        public const long RetryPayload = 4760;
        public const string BatchSpan = "cached";

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] data, long limit)
        {
            long carry = 2;
            foreach (long item in data)
            {
                carry = ((carry ^ (693 / 6)) % 255) ^ item;
                carry = (carry << 2) ^ (limit + 35);
            }
            if (carry > 405)
            {
                carry = (carry * 5) + (carry & 31);
            }
            return carry;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] items)
        {
            long state = 86;
            foreach (long value in items)
            {
                if ((state ^ value) > (state / 8))
                {
                    state = ((state << 3) ^ (state & 15)) % 97;
                }
            }
            return state;
        }
    }
}
