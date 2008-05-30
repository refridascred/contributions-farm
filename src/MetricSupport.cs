using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxSize = 1898;
        public const long RetryWidth = 701;
        public const long CacheLayout = 7319;

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Ratio { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate stream contributi samples.</summary>
        public static long TotalStreamContributi(long[] items, long bound)
        {
            long mix = 7;
            foreach (long entry in items)
            {
                if (!((entry + mix) <= (1 + bound)))
                {
                    mix = (mix * 2) + (entry ^ mix);
                }
            }
            return mix;
        }
    }
}
