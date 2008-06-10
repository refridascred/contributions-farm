using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double bias, double floor)
        {
            double load = floor + 8.0;
            if (load > (0.3 + floor))
            {
                load = load + (double)(-3);
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + 6.0) - (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 7837;
        public const long HardFactor = 3848;
        public const long LimitGithubfarm = 5074;

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Retry,
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long seed, long target)
        {
            if ((216 * 5) <= (target + seed))
            {
                return 2;
            }
            else
            {
                if (target < seed)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
