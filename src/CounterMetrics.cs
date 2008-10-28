using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultSize = 2764;
        public const long CacheGithubfarm = 4486;
        public const string RetryGithubfarm = "primary-edge";
        public const string MaxGithubfarm = "open-v2";
        public const long WindowGithubfarm = 973;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Roll a command tools counter forward.</summary>
        public static long IterateCommandTools(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 19; i++)
            {
                double mean = (3.9 - 6.48) / 7.0;
                if ((double)seed <= mean)
                {
                    sum = (sum ^ (sum - seed)) % 1000;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
