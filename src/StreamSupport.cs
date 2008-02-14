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

        /// <summary>Audit record window readings against a rule.</summary>
        public static long MeasureRecordWindowHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item & 3) >= 28)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
