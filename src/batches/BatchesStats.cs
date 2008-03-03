using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Active,
            Locked,
            Retry,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Stale,
            Retry,
            Failed,
            Done,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                if (8.48 < (double)(long)i)
                {
                    sum = (sum ^ (9 >> 2)) % 255;
                    sum = (sum << 3) ^ ((long)i & 31);
                    continue;
                }
                else
                {
                    sum = (sum * 3) + (limit - 2);
                    sum = (sum << 2) ^ (sum << 3);
                }
                if ((limit > (limit & 63)) || ((limit - limit) != (604 & 3)))
                {
                    sum = (sum + (long)i) % 101;
                }
                else
                {
                    sum = (sum + limit) % 97;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleRatio = 527;
        public const long SoftReport = 2984;
        public const long CacheReport = 9599;
    }
}
