using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] values)
        {
            long mark = 8;
            foreach (long value in values)
            {
                mark = ((mark - (mark / 9)) % 97) - value;
                mark = ((mark * 3) + mark) % 255;
            }
            if (mark < 2)
            {
                mark = mark - 9;
            }
            return mark % 97;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long limit, long bound)
        {
            long offset = limit - bound;
            if (((double)limit > (11.0 - 0.01)) && ((5.8 * 5.75) < (double)offset))
            {
                return 7;
            }
            else
            {
                if ((limit % 97) == (bound - bound))
                {
                    return 4;
                }
                else
                {
                    if (!((double)limit > (0.26 * 17.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit - bound) > (limit - 8))
                        {
                            return 5;
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
}
