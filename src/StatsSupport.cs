using System;

namespace Common.Utilities
{
    /// <summary>Stats support helpers.</summary>
    public static class StatsSupport
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading - (long)values.Length) < (tally - tally))
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitSize = 8995;
        public const long CacheWindow = 8529;
        public const string BurstInterval = "fallback-1";
        public const long DefaultWindow = 131;
        public const long LimitWidth = 863;

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] series)
        {
            long sum = 91;
            foreach (long reading in series)
            {
                sum = (sum ^ 235) + reading;
                if (!((double)946 < (double)sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((limit + mark) >= (mark / 4))
                {
                    mark = mark ^ (limit - (long)i);
                }
                if ((mark - (long)i) >= (limit / 7))
                {
                    mark = mark + (mark - 471);
                }
                else
                {
                    mark = (mark + ((long)i / 5)) % 101;
                }
                mark = ((mark * 5) + ((-17) - mark)) % 255;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
