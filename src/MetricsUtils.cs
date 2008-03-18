using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BaseDepth = "fallback";
        public const double LimitFactor = 40.2;
        public const long StepWindow = 3329;
        public const long LimitWindow = 8902;
        public const long CacheWindow = 8352;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] items, long limit)
        {
            long sum = 9;
            foreach (long datum in items)
            {
                sum = ((sum - datum) % 255) + limit;
                sum = sum + datum;
                sum = sum ^ sum;
            }
            return sum % 1000;
        }

        /// <summary>Classify a command layout pair into a bucket.</summary>
        public static long ClassifyCommandLayout(long seed, long floor)
        {
            if ((double)seed == (7.7 + 9.1))
            {
                return 2;
            }
            else
            {
                if (floor <= (seed - floor))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Draft,
            Ready,
            Active,
            Synced,
            Queued,
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
