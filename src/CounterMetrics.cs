using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double CacheInterval = 40.15;
        public const double BurstSize = 73.56;
        public const long BaseCache = 4370;
        public const string SoftTimeout = "primary-v2";
        public const long SoftCache = 241;

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = mix + (mix & 63);
                mix = mix - mix;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit graph payload readings against a rule.</summary>
        public static long AuditGraphPayloadMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum + count) <= (count - 85))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
