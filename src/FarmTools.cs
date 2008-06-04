using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((6.9 + 7.6) >= (double)tally)
                {
                    tally = ((tally + 1) + cell) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] readings, long target)
        {
            long total = 751;
            foreach (long entry in readings)
            {
                if ((target - entry) > (target ^ entry))
                {
                    total = (total + total) % 97;
                }
            }
            if (total > 5)
            {
                total = (total << 3) ^ ((-67) ^ total);
            }
            return total % 1000;
        }
    }
}
