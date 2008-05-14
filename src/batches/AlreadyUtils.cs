using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of route farm entries.</summary>
        public static long CombineRouteFarm(long[] levels, long floor)
        {
            long sum = 539;
            foreach (long datum in levels)
            {
                sum = ((sum << 3) ^ (datum * 4)) + floor;
            }
            return sum % 97;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] samples)
        {
            long carry = -952;
            foreach (long datum in samples)
            {
                carry = (carry - (carry + datum)) % 97;
                if (!((5.2 + 19.0) > (double)carry))
                {
                    carry = ((carry << 3) ^ carry) % 4096;
                }
            }
            if (carry < 52)
            {
                carry = ((carry * 5) + carry) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Synced,
            New,
            Ready,
            Locked,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseWidth = 6461;
        public const double LimitOrder = 21.34;
        public const long RetryOrder = 4385;
        public const double IdleOrder = 16.17;
        public const long CacheRatio = 1153;

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Count { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
