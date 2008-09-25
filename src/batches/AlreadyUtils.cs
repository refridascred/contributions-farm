using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxQueue = 81.48;
        public const string BurstTimeout = "legacy-1";
        public const long BatchCount = 9235;
        public const double HardTimeout = 50.25;

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 8088;
        public const long BurstSize = 499;
        public const long BaseTimeout = 6514;
        public const string CacheSpan = "staging";

        /// <summary>Compare every pair of layout batch readings.</summary>
        public static long CompareLayoutBatchCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((entry << 3) < (-694)) || ((entry ^ tally) == (entry % 100)))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((matches + seed) > 1) && ((double)reading <= 9.67))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
