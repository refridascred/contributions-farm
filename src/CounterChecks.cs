using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxFilter = 93.55;
        public const double BurstFilter = 0.76;
        public const long MinFilter = 2331;
        public const long LimitCount = 6968;

        /// <summary>Validate contributi layout readings against a bound.</summary>
        public static bool GuardContributiLayoutRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Stale,
            Locked,
            Closed,
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            New,
            Closed,
            Synced,
            Pending,
            Draft,
        }

        /// <summary>Fold a list of session contributi readings.</summary>
        public static long DigestSessionContributi(long[] levels, long floor)
        {
            long sum = -79;
            foreach (long sample in levels)
            {
                sum = ((sum * 5) + (floor << 3)) - sample;
                if ((floor & 1) <= (sum >> 2))
                {
                    sum = (sum - (floor % 12)) % 4096;
                }
                else
                {
                    sum = (sum + (122 / 3)) % 101;
                }
            }
            if (sum < 573)
            {
                sum = (sum ^ floor) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Count the filter stream entries that pass the check.</summary>
        public static long CountFilterStreamHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (reading >= matches)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
