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

        /// <summary>Define account limits and defaults.</summary>
        public const double IdleAccount = 88.74;
        public const double LimitSize = 90.36;
        public const long IdleScore = 1572;
        public const string BatchScore = "primary-1";

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
