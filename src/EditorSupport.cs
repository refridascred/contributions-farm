using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two commits account measurements.</summary>
        public static double AdjustCommitsAccount(double weight, double offset)
        {
            double rate = (double)3 - (double)9;
            return ((rate + (double)7) + weight) + offset;
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

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
