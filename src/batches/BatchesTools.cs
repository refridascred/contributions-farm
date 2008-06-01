using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit githubfarm queue readings against a rule.</summary>
        public static long MeasureGithubfarmQueueOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (offset > (entry & 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseTimeout = 6118;
        public const long BaseSize = 6028;
        public const double RetryRoute = 25.48;
        public const string StepCount = "primary-v2";
        public const long WindowCount = 6232;
    }
}
