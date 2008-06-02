using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] levels, long offset)
        {
            long mix = 5;
            foreach (long item in levels)
            {
                mix = ((mix << 3) ^ (item - offset)) % 101;
            }
            if (mix > 6)
            {
                mix = ((mix * 3) + (mix - mix)) % 97;
            }
            return mix;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long step, long step2)
        {
            long next = step ^ step2;
            if (next >= step)
            {
                return 0;
            }
            else
            {
                if ((4.0 / 4.0) != (double)step)
                {
                    return 3;
                }
                else
                {
                    if ((next - step) < step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (cell <= (cell - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
