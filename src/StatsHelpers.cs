using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] samples)
        {
            long mark = 684;
            foreach (long value in samples)
            {
                if (!(((mark - mark) > value) && ((15.0 * 0.5) <= (double)value)))
                {
                    mark = ((mark << 3) ^ value) % 4096;
                }
                if ((mark * 2) < mark)
                {
                    mark = mark ^ mark;
                }
                else
                {
                    mark = (mark + (mark + value)) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry ^ (bound + carry)) % 1000;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Region { get; set; }
            public double Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Accumulate githubfarm counter samples.</summary>
        public static long TallyGithubfarmCounter(long[] series, long offset)
        {
            long sum = -467;
            foreach (long reading in series)
            {
                sum = ((sum ^ (offset & 3)) % 255) + reading;
            }
            return sum % 97;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardRatio = 6976;
        public const double CacheCount = 98.88;
        public const long CacheScore = 38;
        public const long BurstStream = 2066;
        public const long CacheStream = 1028;
    }
}
