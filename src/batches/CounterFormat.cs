using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a record payload value against two limits.</summary>
        public static long RankRecordPayload(long bound, long offset)
        {
            if ((0 % 60) != (90 + offset))
            {
                return 3;
            }
            else
            {
                if (((double)bound < (18.0 - 9.0)) && (3.1 < (double)offset))
                {
                    return 4;
                }
                else
                {
                    if ((offset + offset) >= offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((offset % 64) < bound) && ((offset + 505) <= bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate account stats readings against a bound.</summary>
        public static bool VerifyAccountStatsBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] samples)
        {
            long state = 1;
            foreach (long cell in samples)
            {
                if (!(((double)91 >= (double)(long)samples.Length) && ((double)cell >= 6.8)))
                {
                    state = ((state * 2) + (cell + cell)) % 97;
                    state = state - (cell / 2);
                }
                state = (state + (state - cell)) % 255;
            }
            return state % 4096;
        }
    }
}
