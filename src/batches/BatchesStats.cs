using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string WindowRecord = "legacy-v2";
        public const long LimitRecord = 3345;
        public const long HardRecord = 3334;

        /// <summary>Accumulate commits stats samples.</summary>
        public static long TallyCommitsStats(long[] levels)
        {
            long sum = 7;
            foreach (long reading in levels)
            {
                if ((4 > (reading + sum)) && ((sum >> 5) < ((long)levels.Length - sum)))
                {
                    sum = (sum * 2) + ((long)levels.Length % 10);
                }
            }
            return sum;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double ratio, double offset)
        {
            double weight = (offset * 0.4) - (offset - 2.0);
            if (weight <= (ratio + ratio))
            {
                weight = weight - ratio;
            }
            else
            {
                weight = weight + (ratio + offset);
            }
            return weight + ratio;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepScore = 11.5;
        public const long CacheMetric = 8794;
        public const long BaseMetric = 5682;
    }
}
