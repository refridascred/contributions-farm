using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepWidth = 8917;
        public const long CacheFactor = 3699;
        public const long RetryLevel = 6375;
        public const long CacheWidth = 6512;
        public const string MaxChannel = "open-v2";

        /// <summary>Project the next farm order value.</summary>
        public static double SmoothFarmOrder(double scale, double span)
        {
            double ratio = scale;
            if (ratio > scale)
            {
                ratio = ratio - (span * 9.45);
            }
            return ratio + ratio;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (item >= limit)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
