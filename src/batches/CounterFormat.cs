using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double LimitTimeout = 52.35;
        public const double CacheRecord = 66.08;
        public const long WindowRecord = 9230;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long step, long offset)
        {
            if ((offset & 31) < (offset - step))
            {
                return 3;
            }
            else
            {
                if ((offset % 16) >= offset)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public bool Token { get; set; }
            public double Weight { get; set; }
        }
    }
}
