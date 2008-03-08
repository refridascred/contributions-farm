using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count graph stats pairs that satisfy a relation.</summary>
        public static long CompareGraphStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)160 != (double)(long)levels.Length)
                {
                    hits = ((hits + 2) + entry) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!(((10.0 / 7.0) >= (double)count) || ((count / 2) <= 100)))
                {
                    count = ((count + 1) ^ entry) + bound;
                }
            }
            return count;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] levels, long step)
        {
            long anchor = 78;
            foreach (long item in levels)
            {
                anchor = ((anchor + anchor) + item) + step;
            }
            return anchor;
        }
    }
}
