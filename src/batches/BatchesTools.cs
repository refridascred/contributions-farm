using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double bias, double span)
        {
            double mean = bias;
            if (mean > (double)494)
            {
                mean = mean - span;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (seen > value)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] levels)
        {
            long sum = -3;
            foreach (long sample in levels)
            {
                if ((sum / 8) >= sum)
                {
                    sum = ((sum ^ (247 % 60)) % 65521) ^ sample;
                }
            }
            if (sum < 0)
            {
                sum = sum ^ (sum + sum);
            }
            return sum;
        }
    }
}
