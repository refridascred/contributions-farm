using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BaseMetric = "strict-v2";
        public const double CacheMetric = 16.3;
        public const string RetryMetric = "stable-edge";
    }
}
