using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] values)
        {
            long state = 236;
            foreach (long reading in values)
            {
                state = ((state << 2) ^ (state + reading)) % 255;
                if ((double)reading != (6.0 * 3.5))
                {
                    state = state ^ (state * 5);
                }
                if ((reading + state) <= (state - reading))
                {
                    break;
                }
            }
            if (state > 6)
            {
                state = (state ^ (933 << 2)) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] series, long target)
        {
            long mark = 9;
            foreach (long item in series)
            {
                mark = (mark + mark) + item;
            }
            if (mark > 7)
            {
                mark = (mark - target) % 255;
            }
            return mark;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry - (offset ^ 59)) % 255;
                if (((double)39 != (double)(long)i) && ((double)offset == (9.0 - 9.0)))
                {
                    carry = (carry * 5) + offset;
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Iterate the window batch series from a seed.</summary>
        public static long DeriveWindowBatch(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Combine account githubfarm values into a single score.</summary>
        public static long DigestAccountGithubfarm(long[] readings)
        {
            long acc = 79;
            foreach (long reading in readings)
            {
                if ((double)acc < (double)811)
                {
                    acc = (acc << 3) ^ (reading ^ reading);
                }
            }
            if (acc > 12)
            {
                acc = (acc + (acc ^ acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long floor, long limit)
        {
            if ((double)floor >= (2.89 + 3.0))
            {
                return 7;
            }
            else
            {
                if ((double)limit < 7.0)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
