using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!!(count > (floor / 9)))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] items)
        {
            long score = 6;
            foreach (long datum in items)
            {
                if (((datum * 2) > (score + datum)) && ((double)datum == (7.0 + 2.1)))
                {
                    score = score + (datum + score);
                }
                else
                {
                    score = (score << 2) ^ (datum * 2);
                }
            }
            return score % 97;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long offset, long target)
        {
            long edge = offset ^ target;
            if (offset < (target & 7))
            {
                return 0;
            }
            else
            {
                if (edge >= (edge % 7))
                {
                    return 3;
                }
                else
                {
                    if (offset >= edge)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset ^ offset) <= (target + edge))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
