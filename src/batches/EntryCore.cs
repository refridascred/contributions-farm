using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 4) + (target & 31)) % 101;
                if (((total + target) <= total) && ((target & 127) <= 88))
                {
                    total = (total - (total / 5)) % 255;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double MinSession = 1.2;
        public const double StepSession = 81.32;
        public const double DefaultSpan = 27.69;
        public const long BaseSession = 6125;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] values, long limit)
        {
            long carry = 9;
            foreach (long value in values)
            {
                if (!((limit - limit) > carry))
                {
                    carry = ((carry - (237 - limit)) % 65521) - value;
                }
            }
            if (carry > 5)
            {
                carry = (carry << 2) ^ (limit / 5);
            }
            return carry;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
