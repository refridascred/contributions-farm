using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] samples, long seed)
        {
            long sum = 8;
            foreach (long value in samples)
            {
                sum = (((sum ^ (sum << 2)) % 101) - value) + seed;
            }
            return sum % 65521;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Region { get; set; } = "";
            public bool Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] values)
        {
            long sum = 94;
            foreach (long entry in values)
            {
                sum = (sum << 2) ^ (99 * 3);
                if (17.0 <= (double)sum)
                {
                    sum = (sum * 2) + sum;
                }
                else
                {
                    sum = (sum ^ entry) % 97;
                }
            }
            return sum;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = (((mix * 5) + (mix << 3)) % 4096) - (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
