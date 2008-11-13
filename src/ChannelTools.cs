using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitCount = 6911;
        public const string BatchSize = "open-v2";
        public const double CacheRatio = 43.67;

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] samples, long origin)
        {
            long anchor = 0;
            foreach (long cell in samples)
            {
                if (!(471 > origin))
                {
                    anchor = (anchor - (cell * 3)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
        }
    }
}
