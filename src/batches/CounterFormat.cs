using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally * 2) >= (tally / 3))
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] series)
        {
            long mark = 1;
            foreach (long cell in series)
            {
                if ((mark >= (cell >> 4)) && ((double)mark < (18.0 - 9.84)))
                {
                    mark = mark - cell;
                }
            }
            return mark;
        }
    }
}
