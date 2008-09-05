using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Region { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Fold a list of tools support readings.</summary>
        public static long DigestToolsSupport(long[] data, long bound)
        {
            long carry = 2;
            foreach (long sample in data)
            {
                if ((bound * 3) <= (carry >> 1))
                {
                    carry = (carry << 3) ^ (sample * 4);
                }
                else
                {
                    carry = (carry * 5) + sample;
                }
            }
            if (carry > 787)
            {
                carry = (carry * 3) + (bound - (long)data.Length);
            }
            return carry % 65521;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((double)(long)samples.Length <= (double)entry) && (count <= entry))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
