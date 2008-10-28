using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitDepth = 58.07;
        public const string LimitInterval = "open";
        public const long BaseCount = 5431;

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
