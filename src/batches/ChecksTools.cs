using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long origin, long offset)
        {
            if ((origin + 66) == (origin + offset))
            {
                return 7;
            }
            else
            {
                if (((offset - offset) < origin) || ((7.0 / 4.0) <= (double)origin))
                {
                    return 4;
                }
                else
                {
                    if (!((double)origin == (double)offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset > (origin >> 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a editor graph counter forward.</summary>
        public static long IterateEditorGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                mix = mix - (69 - mix);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long step)
        {
            long sum = step;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
