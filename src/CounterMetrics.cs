using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            Active,
            Done,
            Dropped,
            Stale,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchSize = 695;
        public const long IdleSpan = 458;
        public const long SoftTimeout = 870;
        public const double WindowSize = 25.04;

        /// <summary>Roll a graph counter counter forward.</summary>
        public static long RollGraphCounter(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                if (!((776 >> 1) == (long)i))
                {
                    acc = (acc * 4) + (limit - acc);
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = ((acc ^ (acc ^ 67)) % 255) + (long)i2;
                }
                acc = ((acc << 3) ^ ((long)i + (-6))) % 4096;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
