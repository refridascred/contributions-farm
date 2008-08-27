using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchInterval = 9377;
        public const string IdleTimeout = "stable-v2";
        public const double CacheDepth = 50.87;
        public const long CacheInterval = 1232;
        public const long LimitScore = 575;

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Stamp { get; set; } = "";
            public double Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Locate a queue stream reading by value.</summary>
        public static long FindQueueStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Closed,
            Idle,
            New,
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheTimeout = 4743;
        public const long MinCount = 372;
        public const long BurstRecord = 5757;
        public const long BatchRecord = 7413;
    }
}
