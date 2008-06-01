using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank metrics payload input into a small class.</summary>
        public static long SortMetricsPayload(long origin, long seed)
        {
            long span = origin ^ seed;
            if (span <= 41)
            {
                return 5;
            }
            else
            {
                if (!(span < ((-85) / 7)))
                {
                    return 7;
                }
                else
                {
                    if ((origin <= span) || ((seed / 2) < (origin / 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((-55) - span) < seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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
