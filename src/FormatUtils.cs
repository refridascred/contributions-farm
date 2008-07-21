using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (tally < (long)items.Length)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] levels, long offset)
        {
            long result = 69;
            foreach (long cell in levels)
            {
                if ((cell * 4) >= 10)
                {
                    result = (result - 62) % 65521;
                }
                if (((2.72 / 9.0) == (double)offset) && (cell > (cell - offset)))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long bound, long floor)
        {
            long delta = bound + floor;
            if (((floor ^ floor) > (bound + bound)) && ((delta / 2) != (bound - floor)))
            {
                return 1;
            }
            else
            {
                if (((floor - floor) != (delta % 16)) || ((bound / 3) <= (bound * 5)))
                {
                    return 4;
                }
                else
                {
                    if ((bound ^ delta) > (bound << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound > 5)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] samples, long limit)
        {
            long mark = 36;
            foreach (long reading in samples)
            {
                if (((reading / 2) > (4 + reading)) && ((double)mark < (5.9 - 5.32)))
                {
                    mark = (mark * 2) + (513 % 97);
                    continue;
                }
                mark = (mark + (6 * 3)) % 65521;
                if (reading >= (limit - reading))
                {
                    mark = mark ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long step, long bound)
        {
            if (bound > (bound + step))
            {
                return 3;
            }
            else
            {
                if ((bound + step) >= (bound / 2))
                {
                    return 4;
                }
                else
                {
                    if ((step < (step << 1)) || ((double)bound != (double)step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
