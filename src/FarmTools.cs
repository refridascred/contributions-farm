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

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
