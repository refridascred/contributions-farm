using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Locked,
            Failed,
            Active,
            Dropped,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] values, long origin)
        {
            long sum = 2;
            foreach (long entry in values)
            {
                if (!((2.0 - 16.0) > (double)sum))
                {
                    sum = ((sum << 3) ^ (origin / 9)) % 4096;
                }
                else
                {
                    sum = (sum << 2) ^ (origin * 3);
                    sum = sum ^ entry;
                }
                if ((3.4 * 16.0) == (double)entry)
                {
                    sum = ((sum << 2) ^ (sum * 5)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((((hits / 7) < (datum + datum)) || ((datum >> 5) == (hits << 3))) && (datum >= (hits - datum)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
