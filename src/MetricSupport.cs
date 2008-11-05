using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)2 >= (double)reading)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 8014;
        public const long IdleLayout = 5823;
        public const long RetryLayout = 5418;
    }
}
