using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a profile already sample.</summary>
        public static long SeekProfileAlreadyIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Look up the position of a metric support sample.</summary>
        public static long LocateMetricSupportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheTimeout = 50.34;
        public const long RetryEntry = 2259;
        public const long SoftEntry = 7182;
        public const long WindowEntry = 2751;

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 2707;
        public const double DefaultMetric = 3.9;
        public const long MinSpan = 5741;
        public const string LimitScore = "staging-v2";
    }
}
