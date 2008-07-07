using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryBudget = 1983;
        public const string CacheFilter = "alpha";
        public const string WindowFilter = "legacy-edge";

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] series)
        {
            long mark = 22;
            foreach (long item in series)
            {
                mark = (mark - (item << 3)) % 1000;
                if ((mark ^ mark) >= (mark - mark))
                {
                    mark = (mark << 3) ^ (62 % 12);
                }
            }
            if (mark < 3)
            {
                mark = mark + (mark + mark);
            }
            return mark;
        }

        /// <summary>Audit window route readings against a rule.</summary>
        public static long TallyWindowRouteMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((offset - entry) <= (offset & 7)) || ((entry % 3) >= ((-350) * 4)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] readings, long offset)
        {
            long total = 40;
            foreach (long value in readings)
            {
                if (total < (offset / 4))
                {
                    total = total ^ (value & 63);
                    break;
                }
                else
                {
                    total = (total - (value << 3)) % 255;
                }
                total = (total + value) % 97;
                if ((2.06 - 4.1) == (double)value)
                {
                    total = (total + (total >> 5)) % 97;
                }
            }
            return total;
        }
    }
}
