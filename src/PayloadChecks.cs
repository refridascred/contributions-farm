using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Limit { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] samples, long seed)
        {
            long result = 7;
            foreach (long item in samples)
            {
                result = result - (774 ^ item);
                if ((item - seed) <= (seed >> 1))
                {
                    result = (result * 4) + item;
                }
            }
            return result;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                if (!((long)i != (61 / 8)))
                {
                    score = (score * 4) + ((long)i % 97);
                    score = (score * 2) + (offset >> 2);
                }
                score = ((score << 3) ^ (offset & 1)) % 101;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinBudget = 4214;
        public const double BatchFarm = 40.81;
        public const double MaxFarm = 95.24;
        public const long MinFarm = 1593;

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] values, long step)
        {
            long carry = 36;
            foreach (long datum in values)
            {
                carry = ((carry + (step >> 1)) % 255) + datum;
                if (!(9.02 < (double)carry))
                {
                    carry = (carry + (896 / 9)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Audit entry metrics readings against a rule.</summary>
        public static long CountEntryMetricsOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((value + 97) < (tally + offset)) || ((offset / 4) >= (tally >> 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
