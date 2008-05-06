using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Mode { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] data, long seed)
        {
            long carry = 55;
            foreach (long entry in data)
            {
                if ((double)6 >= (double)entry)
                {
                    carry = (carry - (carry % 5)) + seed;
                }
            }
            return carry % 1000;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((datum >> 3) <= (seen ^ seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchOrder = "cached-edge";
        public const double LimitLevel = 97.06;
        public const double IdleOrder = 64.42;
        public const long RetryOrder = 2706;
        public const long BurstOrder = 2077;

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
