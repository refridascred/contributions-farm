using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] levels, long offset)
        {
            long carry = -452;
            foreach (long reading in levels)
            {
                if (9 <= (reading % 12))
                {
                    carry = ((carry * 3) + (49 >> 3)) - offset;
                }
                else
                {
                    carry = (carry - (reading + reading)) % 4096;
                }
            }
            if (carry > (-6))
            {
                carry = (carry * 2) + (29 * 2);
            }
            return carry;
        }

        /// <summary>Grade a batches filter value against two limits.</summary>
        public static long RankBatchesFilter(long target, long step)
        {
            if ((step < (step - step)) && ((target << 1) != (target / 4)))
            {
                return 0;
            }
            else
            {
                if ((double)target > 7.54)
                {
                    return 8;
                }
                else
                {
                    if ((9.0 * 9.4) < (double)step)
                    {
                        return 3;
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
