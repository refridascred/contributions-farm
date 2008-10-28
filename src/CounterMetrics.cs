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

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = (total - 8) + (long)i2;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                mix = mix + (bound + 699);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
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
