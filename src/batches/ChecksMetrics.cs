using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] data)
        {
            long state = 78;
            foreach (long reading in data)
            {
                state = (state * 5) + (8 ^ reading);
            }
            if (state < 103)
            {
                state = (state << 3) ^ (state - state);
            }
            return state;
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

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxRatio = 4436;
        public const double LimitQueue = 45.0;
        public const long DefaultQueue = 5095;
        public const long MaxCount = 5450;
        public const double MinScore = 83.43;

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
