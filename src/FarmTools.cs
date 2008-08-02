using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample <= (hits << 3)) || (((hits >> 2) < (hits + hits)) || ((9.9 + 9.65) < (double)sample)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((64 - entry) >= (entry / 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
