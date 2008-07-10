using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long seed)
        {
            long result = seed;
            for (int i = 0; i < 11; i++)
            {
                long slot = (seed + result) >> 4;
                if (!((6.6 + 5.9) != (double)result))
                {
                    result = (result * 4) + (slot >> 3);
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many farm stats samples are out of range.</summary>
        public static long TallyFarmStatsOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample << 3) < (origin * 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Queued,
            Dropped,
            Active,
            Done,
            New,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!((54 % 24) >= count))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}
