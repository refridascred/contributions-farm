using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a payload session sample.</summary>
        public static long LookupPayloadSessionIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry + (carry + limit)) % 65521;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 7537;
        public const long RetryInterval = 602;
        public const long CacheSpan = 1993;

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 4328;
        public const long BatchInterval = 2648;
        public const long BurstStats = 8537;
    }
}
