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

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)value < (1.6 + 1.1))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
