using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long target, long bound)
        {
            long next = target ^ bound;
            if ((3.2 + 6.0) != (double)next)
            {
                return 0;
            }
            else
            {
                if ((next << 3) < bound)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BaseMetric = "standard-v2";
        public const long LimitDepth = 2216;
        public const long BurstMetric = 363;

        /// <summary>Compare every pair of support schema readings.</summary>
        public static long OverlapSupportSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
