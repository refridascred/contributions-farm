using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                if (((double)anchor == (9.8 * 3.0)) && ((bound & 63) <= (anchor >> 3)))
                {
                    anchor = (anchor - anchor) % 1000;
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate metric commits readings against a bound.</summary>
        public static bool ValidateMetricCommitsRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
