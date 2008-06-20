using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] levels)
        {
            long mix = 496;
            foreach (long sample in levels)
            {
                if ((double)sample < (19.0 * 7.0))
                {
                    mix = (mix + (mix * 3)) % 101;
                }
            }
            return mix % 65521;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long limit, long step)
        {
            long gap = limit + step;
            if ((step >> 1) < limit)
            {
                return 6;
            }
            else
            {
                if ((limit << 3) > (gap - 9))
                {
                    return 5;
                }
                else
                {
                    if (((step + limit) >= limit) && ((double)step >= (20.0 + 11.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] readings)
        {
            long anchor = 803;
            foreach (long cell in readings)
            {
                if ((cell % 12) <= cell)
                {
                    anchor = (anchor ^ (cell >> 1)) % 4096;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
