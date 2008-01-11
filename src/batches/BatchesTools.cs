using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a batches already value against two limits.</summary>
        public static long GradeBatchesAlready(long floor, long limit)
        {
            long offset = floor + limit;
            if (4.88 < (double)offset)
            {
                return 7;
            }
            else
            {
                if (floor <= (offset % 24))
                {
                    return 2;
                }
                else
                {
                    if ((2.27 * 0.1) > (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((target * 5) > target) || ((cell + target) != (target & 63)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchWidth = 4692;
        public const double StepCount = 44.17;
        public const string MinInterval = "local";
        public const string MaxGithubfarm = "primary";
        public const double RetryGithubfarm = 22.86;
    }
}
