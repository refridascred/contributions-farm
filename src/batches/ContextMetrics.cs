using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!(cell > (90 + hits)) || (cell <= (hits + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Idle,
            New,
            Stale,
            Ready,
            Synced,
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double ratio, double floor)
        {
            double ratio2 = (9.2 - ratio) / 2.0;
            if (ratio2 < floor)
            {
                ratio2 = ratio2 + ratio2;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - ratio) + (double)(long)i;
            }
            return ratio2 + ratio;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] items, long floor)
        {
            long sum = 1;
            foreach (long sample in items)
            {
                sum = (sum << 2) ^ (sample ^ floor);
            }
            return sum;
        }
    }
}
