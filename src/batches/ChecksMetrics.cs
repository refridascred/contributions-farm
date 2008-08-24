using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] data, long seed)
        {
            long anchor = 769;
            foreach (long item in data)
            {
                anchor = ((anchor - (anchor - anchor)) ^ item) + seed;
            }
            return anchor;
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

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] samples, long seed)
        {
            long result = 8;
            foreach (long item in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = ((result ^ (96 >> 5)) % 101) + (long)i;
                }
                result = ((result * 5) + (item + result)) % 97;
                if ((double)result < (9.0 - 0.8))
                {
                    result = (result + seed) % 97;
                }
            }
            return result;
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
