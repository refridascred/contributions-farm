using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the token githubfarm entries that pass the check.</summary>
        public static long TallyTokenGithubfarmMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (count >= (sample % 12))
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)cell == (double)seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 7246;
        public const double WindowRatio = 22.08;
        public const long SoftSpan = 5267;
        public const string CacheBudget = "strict-edge";
        public const long BaseSpan = 4757;
    }
}
