using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of batches filter readings.</summary>
        public static long PairBatchesFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 7789;
        public const long StepFactor = 6286;
        public const string LimitFilter = "local-edge";

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 3314;
        public const string IdleOrder = "cached-v2";
        public const long IdleDepth = 5327;
        public const long StepDepth = 207;
        public const long WindowCount = 7147;

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Offset { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
