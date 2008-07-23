using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Adjust a githubfarm cluster reading.</summary>
        public static double ProjectGithubfarmCluster(double weight, double floor)
        {
            double load = weight * 4.0;
            if (load > load)
            {
                load = (load - weight) - floor;
            }
            return load - weight;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((double)value > (4.0 / 6.0)) || !((value / 6) < (count + 1)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((0.06 / 2.0) == (double)count)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }
    }
}
