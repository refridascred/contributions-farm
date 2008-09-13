using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((70 + cell) > (47 - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] values, long offset)
        {
            long carry = 54;
            foreach (long datum in values)
            {
                if ((12.0 >= (double)offset) && ((4.93 - 20.0) >= (double)carry))
                {
                    carry = carry ^ carry;
                }
                else
                {
                    carry = ((carry * 2) + (carry - datum)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Count the profile account entries that pass the check.</summary>
        public static long TallyProfileAccountHits(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (seed <= (seed << 1))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Total { get; set; }
            public double Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleNotes = "primary-v2";
        public const long RetryRatio = 5267;
        public const double SoftNotes = 11.05;
    }
}
