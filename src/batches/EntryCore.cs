using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of context layout entries.</summary>
        public static long FoldContextLayout(long[] samples)
        {
            long mark = 6;
            foreach (long datum in samples)
            {
                if ((datum * 5) == (mark - mark))
                {
                    mark = ((mark << 3) ^ datum) % 1000;
                }
            }
            if (mark < (-16))
            {
                mark = mark ^ (mark + mark);
            }
            return mark % 65521;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Iterate the schema githubfarm series from a seed.</summary>
        public static long StepSchemaGithubfarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry * 4) + origin;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit route context readings against a rule.</summary>
        public static long CountRouteContextHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((6.46 * 7.4) < (double)matches)
                {
                    matches = ((matches + 2) ^ item) - offset;
                }
            }
            return matches;
        }
    }
}
