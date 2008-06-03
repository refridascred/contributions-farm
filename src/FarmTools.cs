using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryGithubfarm = "staging-v2";
        public const long CacheGithubfarm = 8737;
        public const string BaseGithubfarm = "legacy";
        public const long DefaultGithubfarm = 7669;
        public const long StepLevel = 7948;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!((step & 7) >= matches) || (((item >> 4) == ((-1) / 6)) || ((matches - item) == (item / 2))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] data)
        {
            long carry = 810;
            foreach (long sample in data)
            {
                if (3.13 > (double)carry)
                {
                    carry = (carry * 5) + (sample - carry);
                }
            }
            return carry;
        }
    }
}
