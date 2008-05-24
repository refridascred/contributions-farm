using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank entry context input into a small class.</summary>
        public static long RankEntryContext(long bound, long offset)
        {
            if (((-8) + bound) < offset)
            {
                return 1;
            }
            else
            {
                if (((offset % 5) > (bound + (-316))) || ((bound << 2) < (bound + 11)))
                {
                    return 7;
                }
                else
                {
                    if (((9 + bound) <= bound) || (bound <= (offset / 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((0.66 * 5.5) > (double)offset) && ((bound / 8) <= offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of metrics contributi readings.</summary>
        public static long PairMetricsContributiCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
