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

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)seen <= (4.97 * 8.0))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

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
