using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a cache metrics value against two limits.</summary>
        public static long BucketCacheMetrics(long origin, long step)
        {
            if ((step % 12) == (step % 2))
            {
                return 6;
            }
            else
            {
                if ((double)step >= (16.0 - 6.0))
                {
                    return 7;
                }
                else
                {
                    if ((step ^ origin) <= (origin + step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of payload notes readings.</summary>
        public static long DigestPayloadNotes(long[] values)
        {
            long total = 0;
            foreach (long sample in values)
            {
                if (total < (sample + total))
                {
                    total = ((total * 2) + sample) % 255;
                    total = total ^ (long)values.Length;
                }
                if ((0 < (sample * 3)) && ((16.0 / 8.0) == (double)total))
                {
                    total = ((total * 5) + sample) % 101;
                }
            }
            return total % 1000;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long offset, long seed)
        {
            if ((offset >> 5) != (seed / 5))
            {
                return 5;
            }
            else
            {
                if (offset > (7 / 7))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Derive the next already checks value from a seed.</summary>
        public static long IterateAlreadyChecks(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((limit << 2) == ((long)i & 127))
                {
                    mark = mark - (mark << 1);
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
