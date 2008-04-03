using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits >= 3) && ((double)seed == (13.0 / 6.0)))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitCount = 6304;
        public const string BatchContributi = "primary-v2";
        public const long HardRatio = 8592;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Retry,
            Ready,
            New,
            Synced,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Total { get; set; }
            public double Ratio { get; set; }
            public long Score { get; set; }
        }
    }
}
