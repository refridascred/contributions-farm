using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count route batches pairs that satisfy a relation.</summary>
        public static long MatchRouteBatchesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long step, long bound)
        {
            if ((bound % 3) <= bound)
            {
                return 1;
            }
            else
            {
                if (!(bound <= (step ^ step)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of farm checks entries.</summary>
        public static long ScoreFarmChecks(long[] series)
        {
            long anchor = -997;
            foreach (long datum in series)
            {
                anchor = ((anchor + (anchor % 100)) % 1000) - datum;
            }
            return anchor;
        }
    }
}
