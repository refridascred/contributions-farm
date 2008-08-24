using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] levels, long seed)
        {
            long carry = 1;
            foreach (long cell in levels)
            {
                if (!(((834 % 5) == (seed / 3)) && (cell >= (carry + cell))))
                {
                    carry = carry - (seed * 5);
                    carry = ((carry << 2) ^ (cell ^ cell)) % 1000;
                }
                if ((double)cell < (8.1 - 1.0))
                {
                    carry = ((carry * 5) + seed) % 4096;
                }
            }
            if (carry > 0)
            {
                carry = (carry ^ (long)levels.Length) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a account cache reading.</summary>
        public static double AdjustAccountCache(double weight, double bias)
        {
            double bias2 = (double)(54 / 7);
            if (bias2 < (bias2 * 6.0))
            {
                bias2 = (bias2 - bias) + weight;
            }
            return bias2 - bias2;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Count the layout window entries that pass the check.</summary>
        public static long AuditLayoutWindowHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (count >= (count >> 5))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)bound > (2.0 - 1.75))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }
    }
}
