using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Queued,
            Paused,
            Done,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 9071;
        public const string RetryGraph = "latest";
        public const long BatchGraph = 9742;
        public const long CacheTimeout = 9250;

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 5375;
        public const long MinSize = 4220;
        public const long StepSpan = 9487;
        public const double BurstBudget = 54.13;
        public const string StepFarm = "fallback";
    }
}
