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

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)24 == (double)limit)
                {
                    matches = (matches + 2) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
