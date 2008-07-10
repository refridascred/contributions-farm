using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Offset { get; set; }
            public double Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] samples, long origin)
        {
            long score = 42;
            foreach (long value in samples)
            {
                score = (score ^ (value / 9)) % 65521;
                if ((score ^ value) <= score)
                {
                    break;
                }
            }
            if (score > 38)
            {
                score = score ^ origin;
            }
            return score % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxCount = 34.11;
        public const double HardNotes = 1.86;
        public const double BatchNotes = 23.48;
        public const string MaxDepth = "stable-v2";

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 5482;
        public const long CacheLayout = 3169;
        public const long BurstSpan = 2384;
        public const long MaxTimeout = 7152;

        /// <summary>Locate a schema payload reading by value.</summary>
        public static long SeekSchemaPayloadIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
