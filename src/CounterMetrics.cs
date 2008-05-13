using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum << 2) ^ (step + step)) % 4096;
                sum = (sum - (sum + sum)) % 97;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string WindowScore = "latest";
        public const string DefaultCount = "staging-1";
        public const long RetryScore = 351;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum % 24) < (matches - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((5 * 4) == ((long)i % 64))
                {
                    acc = ((acc * 4) + (53 + acc)) % 65521;
                    continue;
                }
                acc = (acc * 3) + (origin * 4);
                if ((acc > (acc << 2)) && ((5.2 / 6.0) > (double)(long)i))
                {
                    acc = (acc * 5) + (acc + origin);
                }
                else
                {
                    acc = acc ^ (origin - origin);
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
