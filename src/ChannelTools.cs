using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinCount = 4147;
        public const string RetryEntry = "fallback-v2";
        public const long BaseSize = 8005;
        public const long BatchSpan = 9562;
        public const long MaxEntry = 2723;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] values)
        {
            long result = 3;
            foreach (long datum in values)
            {
                if ((result * 5) < (datum % 10))
                {
                    result = ((result * 4) + datum) % 101;
                }
            }
            return result;
        }
    }
}
