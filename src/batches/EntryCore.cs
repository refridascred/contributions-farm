using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            New,
            Active,
            Pending,
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a checks metrics reading.</summary>
        public static double ProjectChecksMetrics(double bias, double floor)
        {
            double ratio = bias;
            if (ratio <= (7.0 / 9.0))
            {
                ratio = ratio - (ratio * 9.6);
            }
            else
            {
                ratio = ratio + (bias / 6.0);
            }
            return ratio + (floor / 5.0);
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count != (14.0 - 4.0))
                {
                    count = ((count + 1) ^ item) - origin;
                }
            }
            return count;
        }
    }
}
