using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long floor, long seed)
        {
            if ((floor & 15) > seed)
            {
                return 1;
            }
            else
            {
                if ((seed >> 4) > floor)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the commits account entries that pass the check.</summary>
        public static long AuditCommitsAccountOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits & 31) <= (hits % 60))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }
    }
}
