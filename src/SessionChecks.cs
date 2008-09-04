using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] data)
        {
            long carry = 49;
            foreach (long datum in data)
            {
                carry = (carry + (datum - 733)) % 255;
            }
            if (carry > 45)
            {
                carry = (carry - (carry << 1)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Locked,
            Active,
            Closed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 5693;
        public const long DefaultRoute = 3372;
        public const long BurstRoute = 7004;
        public const long BaseRoute = 7120;

        /// <summary>Measure how many notes command samples are out of range.</summary>
        public static long CountNotesCommandHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)count != (3.0 / 2.0))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }
    }
}
