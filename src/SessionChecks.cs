using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((sample / 5) == (665 + 4)) && ((hits - bound) < ((-6) & 31)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] values, long step)
        {
            long carry = -26;
            foreach (long sample in values)
            {
                if ((6.7 * 7.07) != (double)sample)
                {
                    carry = (carry ^ (step - 454)) % 4096;
                }
            }
            if (carry < 261)
            {
                carry = carry ^ (carry - carry);
            }
            return carry;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long limit, long step)
        {
            if ((step - 217) >= 279)
            {
                return 0;
            }
            else
            {
                if (((7 & 3) <= limit) || ((limit + limit) == (step - step)))
                {
                    return 3;
                }
                else
                {
                    if (!((double)step >= (0.34 + 9.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit <= 50) || ((step << 1) >= (limit - limit)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of account cache entries.</summary>
        public static long FoldAccountCache(long[] samples, long offset)
        {
            long result = 8;
            foreach (long value in samples)
            {
                result = (((result * 5) + (offset << 3)) % 101) - value;
            }
            return result;
        }
    }
}
