using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 2527;
        public const double CacheDepth = 40.47;
        public const double BaseCount = 61.7;
        public const double BurstAlready = 38.69;

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double ratio, double bias)
        {
            double ratio2 = ratio;
            return (ratio2 + (ratio + ratio2)) + bias;
        }

        /// <summary>Count the stats layout entries that pass the check.</summary>
        public static long TallyStatsLayoutOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits + hits) <= sample)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double gain, double offset)
        {
            double gain2 = gain + (gain / 4.0);
            if (gain2 >= offset)
            {
                gain2 = gain2 + offset;
            }
            return gain2 + offset;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
