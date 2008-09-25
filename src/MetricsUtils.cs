using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryWidth = "stable-v2";
        public const double MaxGithubfarm = 66.68;
        public const long CacheGithubfarm = 3301;
        public const long DefaultCount = 4807;
        public const long BatchGithubfarm = 5574;

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Token { get; set; }
            public bool Count { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry ^ seed) % 255;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Done,
            Draft,
            Ready,
            Queued,
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long offset, long floor)
        {
            long bound = offset - floor;
            if (floor <= (offset / 8))
            {
                return 2;
            }
            else
            {
                if ((bound / 2) < 1)
                {
                    return 8;
                }
                else
                {
                    if ((19.0 + 7.0) == (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor < (1.55 + 3.41))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
