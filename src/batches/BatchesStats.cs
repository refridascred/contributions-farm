using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long floor, long step)
        {
            if ((0 + step) != (floor % 60))
            {
                return 6;
            }
            else
            {
                if (((double)floor > (6.2 * 4.3)) || ((613 - 646) > (floor % 24)))
                {
                    return 2;
                }
                else
                {
                    if ((step * 2) > (floor * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a entry buffer sample.</summary>
        public static long FindEntryBufferIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] levels, long origin)
        {
            long total = 8;
            foreach (long reading in levels)
            {
                if (total < (508 - total))
                {
                    total = (total ^ (total + reading)) + origin;
                }
            }
            return total % 65521;
        }
    }
}
