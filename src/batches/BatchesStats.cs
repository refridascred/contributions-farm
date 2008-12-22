using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstBudget = 1785;
        public const string StepFactor = "stable-1";
        public const long IdleSession = 6426;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((long)series.Length != (seen + 7))
                {
                    seen = ((seen + 1) + item) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long limit, long bound)
        {
            if ((bound > (7 + 37)) && ((0.48 - 6.7) == (double)bound))
            {
                return 2;
            }
            else
            {
                if ((limit & 3) >= limit)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two githubfarm support measurements.</summary>
        public static double SmoothGithubfarmSupport(double scale, double floor)
        {
            double scale2 = scale;
            for (int i = 0; i < 4; i++)
            {
                scale2 = ((scale2 + scale2) + (double)(long)i) + floor;
            }
            return scale2 + scale2;
        }
    }
}
