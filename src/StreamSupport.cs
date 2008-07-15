using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleTimeout = 3393;
        public const double BurstLevel = 38.71;
        public const long HardBuffer = 7621;

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] items)
        {
            long result = -520;
            foreach (long item in items)
            {
                if (((result & 7) == (item / 6)) && ((result >> 4) <= result))
                {
                    result = ((result << 3) ^ (-58)) % 65521;
                }
                else
                {
                    result = result + (4 & 7);
                }
            }
            return result;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Total { get; set; }
            public bool Count { get; set; }
            public bool Score { get; set; }
            public long Size { get; set; }
        }
    }
}
