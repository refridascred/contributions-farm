using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
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

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
