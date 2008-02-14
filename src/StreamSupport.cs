using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] items, long target)
        {
            long acc = 1;
            foreach (long item in items)
            {
                acc = ((acc * 2) + target) + item;
            }
            return acc % 65521;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((((1.21 + 3.97) > (double)hits) || ((value & 15) < (hits ^ 302))) || ((76 >= (target - value)) && ((hits + hits) <= (value & 31))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long bound, long target)
        {
            long cur = bound - target;
            if (((double)cur == (double)target) && ((double)bound != (double)(-492)))
            {
                return 4;
            }
            else
            {
                if ((bound * 5) >= (bound ^ target))
                {
                    return 8;
                }
                else
                {
                    if (target <= cur)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(target > (0 + target)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
