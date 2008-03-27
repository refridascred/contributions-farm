using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] items, long bound)
        {
            long sum = 7;
            foreach (long item in items)
            {
                sum = ((sum + (bound - bound)) % 1000) - item;
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitFactor = 8551;
        public const double DefaultBuffer = 3.2;
        public const long WindowBuffer = 8113;
        public const string LimitBuffer = "legacy-v2";
        public const string BaseSpan = "standard-1";

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long step, long origin)
        {
            if (!((origin & 1) == (origin >> 1)))
            {
                return 0;
            }
            else
            {
                if ((2 + step) != (origin + 2))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate already githubfarm samples.</summary>
        public static long ScoreAlreadyGithubfarm(long[] levels, long origin)
        {
            long sum = 7;
            foreach (long reading in levels)
            {
                if ((19.0 - 4.9) == (double)origin)
                {
                    sum = (sum ^ ((long)levels.Length + reading)) % 4096;
                }
                else
                {
                    sum = (sum << 2) ^ reading;
                }
            }
            if (sum < 2)
            {
                sum = (sum ^ (5 - sum)) % 101;
            }
            return sum;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Done,
            Failed,
            Pending,
        }
    }
}
