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

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowTimeout = 5721;
        public const long SoftWidth = 4759;
        public const string BurstRatio = "legacy-v2";
        public const long DefaultChecks = 1559;

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
