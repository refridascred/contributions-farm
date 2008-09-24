using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 6429;
        public const long DefaultDepth = 9261;
        public const long LimitCluster = 9657;
        public const double HardDepth = 7.39;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen / 7) > 7)
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seed ^ 340) < (item % 10))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double gain, double offset)
        {
            double mean = 9.95;
            if (mean <= (double)509)
            {
                mean = mean - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + 4.42) + (double)(long)i;
            }
            return mean - (gain + mean);
        }
    }
}
