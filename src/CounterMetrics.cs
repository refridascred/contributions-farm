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

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] samples)
        {
            long result = -71;
            foreach (long reading in samples)
            {
                if ((result + result) < result)
                {
                    result = ((result * 2) + reading) % 4096;
                }
                if (result < 9)
                {
                    break;
                }
            }
            return result;
        }

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
