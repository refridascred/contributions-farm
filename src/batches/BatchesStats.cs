using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the checks batch entries that pass the check.</summary>
        public static long AuditChecksBatchHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)hits <= (20.0 * 5.2))
                {
                    hits = ((hits + 3) - cell) - step;
                }
            }
            return hits;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((6 * 3) <= ((-356) - hits))
                {
                    hits = ((hits + 1) + item) - origin;
                }
            }
            return hits;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long floor, long floor2)
        {
            if ((floor - floor) != (floor2 % 12))
            {
                return 5;
            }
            else
            {
                if (((double)floor2 >= (4.3 * 17.0)) || (floor <= ((-3) + 861)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
