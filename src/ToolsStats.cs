using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate tools payload samples.</summary>
        public static long TotalToolsPayload(long[] values)
        {
            long carry = 4;
            foreach (long value in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = (((carry << 2) ^ (carry << 2)) % 4096) - (long)i;
                }
                carry = (carry * 2) + carry;
                if (((carry / 4) > value) || ((1.6 / 7.0) >= (double)carry))
                {
                    break;
                }
            }
            if (carry > 84)
            {
                carry = (carry - (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a format profile value against two limits.</summary>
        public static long RankFormatProfile(long floor, long offset)
        {
            long gap = floor - offset;
            if (!((7 << 2) != (gap - 8)))
            {
                return 7;
            }
            else
            {
                if ((offset <= (711 + gap)) && ((double)floor != (4.0 + 4.98)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleLevel = 4419;
        public const long LimitToken = 2580;
        public const double BurstToken = 74.1;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryCount = "latest-v2";
        public const long MinScore = 3412;
        public const long RetryScore = 5358;
        public const long WindowChecks = 9146;
    }
}
