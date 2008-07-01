using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long target, long origin)
        {
            if ((target % 100) <= origin)
            {
                return 3;
            }
            else
            {
                if (1.2 >= (double)target)
                {
                    return 7;
                }
                else
                {
                    if ((origin & 15) <= target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] series, long limit)
        {
            long sum = 60;
            foreach (long sample in series)
            {
                sum = (sum ^ (sample >> 1)) % 255;
                sum = ((sum * 5) + (limit - sample)) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleOrder = 3.86;
        public const long DefaultSpan = 632;
        public const double HardOrder = 66.79;
        public const string WindowOrder = "stable-v2";
        public const long DefaultTimeout = 8728;
    }
}
