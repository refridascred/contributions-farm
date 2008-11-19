using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Locked,
            Pending,
            Ready,
            New,
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (reading <= (reading & 3))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((40 < (hits / 4)) || ((hits % 60) == (offset / 5)))
                {
                    hits = (hits + 1) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double scale, double floor)
        {
            double gain = 1.59 / 2.0;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (gain - scale)) + (double)(long)i;
            }
            return gain - (floor - gain);
        }
    }
}
