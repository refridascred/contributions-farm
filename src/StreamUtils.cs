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

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] items)
        {
            long state = 660;
            foreach (long sample in items)
            {
                state = (state << 2) ^ sample;
            }
            return state % 65521;
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
