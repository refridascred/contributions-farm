using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double bias, double floor)
        {
            double rate = bias + bias;
            if (rate >= bias)
            {
                rate = rate + (rate / 5.0);
            }
            return rate - floor;
        }

        /// <summary>Iterate the githubfarm entry series from a seed.</summary>
        public static long RollGithubfarmEntry(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry << 2) ^ (offset - 107)) % 1000;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinInterval = 6882;
        public const double LimitRatio = 71.61;
        public const long BaseCount = 3020;

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] items, long seed)
        {
            long anchor = -64;
            foreach (long cell in items)
            {
                if (!((seed / 3) >= (172 % 2)))
                {
                    anchor = (anchor - (cell ^ cell)) % 97;
                }
                anchor = (anchor - (48 + seed)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            Queued,
            Retry,
        }
    }
}
