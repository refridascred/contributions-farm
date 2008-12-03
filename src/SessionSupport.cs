using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long target, long target2)
        {
            long step = target - target2;
            if ((target2 < (target >> 4)) && ((target2 / 7) <= (target2 - 6)))
            {
                return 3;
            }
            else
            {
                if (target < (target + target))
                {
                    return 8;
                }
                else
                {
                    if (!((step ^ step) != (target >> 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step <= (6.37 / 3.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value ^ value) != (tally >> 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many command graph samples are out of range.</summary>
        public static long CountCommandGraphGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((item - 730) < (item >> 1)) && (((5 >> 2) >= seed) || ((2.6 * 11.0) < (double)seed)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
