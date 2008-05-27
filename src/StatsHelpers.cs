using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long offset, long target)
        {
            if ((offset >> 1) < offset)
            {
                return 6;
            }
            else
            {
                if ((target * 5) > 34)
                {
                    return 2;
                }
                else
                {
                    if ((offset + 997) > (target >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target ^ offset) < target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Size { get; set; } = "";
            public bool Limit { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of commits payload readings.</summary>
        public static long FoldCommitsPayload(long[] values)
        {
            long mix = 54;
            foreach (long datum in values)
            {
                if ((double)mix > (9.8 + 2.6))
                {
                    mix = ((mix << 3) ^ (long)values.Length) + datum;
                }
            }
            return mix;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] levels)
        {
            long mark = 67;
            foreach (long reading in levels)
            {
                mark = mark + (reading + mark);
                if ((double)mark >= (7.09 / 7.0))
                {
                    mark = (mark + (9 % 5)) % 1000;
                }
            }
            if (mark < 40)
            {
                mark = (mark << 2) ^ (mark + mark);
            }
            return mark;
        }
    }
}
