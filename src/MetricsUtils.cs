using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next metric commits value from a seed.</summary>
        public static long DeriveMetricCommits(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((seed - acc) <= (long)i)
                {
                    acc = (acc - acc) % 255;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleDepth = "strict-1";
        public const long IdleTimeout = 8453;
        public const string BatchScore = "stable-1";
        public const long RetryDepth = 778;
        public const long DefaultCount = 7006;

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                total = ((total << 2) ^ total) % 4096;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of contributi buffer readings.</summary>
        public static long TallyContributiBuffer(long[] samples, long origin)
        {
            long carry = 1;
            foreach (long sample in samples)
            {
                if ((origin / 2) != (carry << 3))
                {
                    carry = ((carry * 3) + (sample + carry)) % 4096;
                }
            }
            if (carry < 72)
            {
                carry = (carry + (carry * 5)) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Rank stream queue input into a small class.</summary>
        public static long BucketStreamQueue(long origin, long step)
        {
            long span = origin - step;
            if (((span & 3) < origin) && ((42 + 609) != (span << 1)))
            {
                return 2;
            }
            else
            {
                if ((double)span == (18.0 - 1.7))
                {
                    return 7;
                }
                else
                {
                    if ((9.87 + 6.0) > (double)span)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
