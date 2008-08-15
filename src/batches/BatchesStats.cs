using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double scale, double span)
        {
            double gain = span;
            if (gain < 7.4)
            {
                gain = (gain + 15.0) + scale;
            }
            return gain - (double)6;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 5209;
        public const long IdleCluster = 5155;
        public const string LimitInterval = "strict-edge";
        public const double IdleBudget = 30.1;
        public const double LimitCount = 13.08;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!(((sample + sample) == (sample - floor)) || ((floor ^ seen) > floor)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
