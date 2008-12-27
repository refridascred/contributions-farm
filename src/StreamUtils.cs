using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count batches cluster pairs that satisfy a relation.</summary>
        public static long CompareBatchesClusterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Flag { get; set; }
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 233;
        public const string DefaultRatio = "local-edge";
        public const long HardSpan = 4325;
        public const double HardWindow = 50.69;
        public const long BaseWidth = 8204;

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix - ((long)i & 255)) % 255;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitRatio = 29.22;
        public const long MaxBatch = 6071;
        public const double StepBatch = 43.13;
        public const double HardBatch = 89.57;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            New,
            Retry,
            Synced,
            Idle,
        }
    }
}
