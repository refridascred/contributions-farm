using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 2511;
        public const long StepRecord = 984;
        public const string WindowScore = "fallback";
        public const long HardDepth = 1553;
        public const long BurstSpan = 3834;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
