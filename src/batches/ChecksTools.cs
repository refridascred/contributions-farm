using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxGraph = 3.9;
        public const double MinWidth = 46.36;
        public const long BaseFactor = 3223;
        public const double StepRatio = 6.88;
        public const long LimitGraph = 5095;

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
