using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next cluster order value from a seed.</summary>
        public static long StepClusterOrder(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                score = score ^ (4 - target);
                if (score >= (long)i)
                {
                    continue;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultOrder = "latest-edge";
        public const long RetryOrder = 9036;
        public const string BurstTimeout = "staging-1";
        public const string MinRatio = "local-1";
        public const double BaseFactor = 9.25;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Pending,
            Failed,
            Done,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((hits + seed) > (2 ^ seed)) && !((6.7 / 7.0) <= (double)seed))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Grade a githubfarm cache value against two limits.</summary>
        public static long ClassifyGithubfarmCache(long limit, long bound)
        {
            long next = limit - bound;
            if (11.0 <= (double)limit)
            {
                return 2;
            }
            else
            {
                if (!((next / 2) > (5 - 573)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
