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

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((step % 10) != (step + step))
                {
                    seen = (seen + 3) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
