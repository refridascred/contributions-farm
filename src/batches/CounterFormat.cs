using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (750 > (cell & 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Retry,
            New,
            Queued,
            Locked,
            Draft,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] items)
        {
            long score = 6;
            foreach (long sample in items)
            {
                if ((double)sample < (9.15 * 12.0))
                {
                    score = (score - (sample % 16)) % 4096;
                }
                else
                {
                    score = (score + (score + score)) % 65521;
                }
            }
            return score;
        }
    }
}
