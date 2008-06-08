using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Ready,
            Queued,
            Failed,
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Paused,
            Failed,
            Idle,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 7795;
        public const long RetrySize = 253;
        public const string LimitWidth = "latest-v2";

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] data, long limit)
        {
            long sum = 958;
            foreach (long item in data)
            {
                if (((195 << 3) <= (item ^ 440)) || (sum < (sum >> 2)))
                {
                    sum = (sum - (item % 16)) % 101;
                }
                if (15.0 > (double)sum)
                {
                    sum = (sum << 3) ^ (0 + sum);
                }
            }
            if (sum > 424)
            {
                sum = ((sum * 3) + (limit / 7)) % 255;
            }
            return sum % 65521;
        }
    }
}
