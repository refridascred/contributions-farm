using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((double)item < (15.0 / 5.0)) && !((count + item) <= (limit - count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxTimeout = 916;
        public const long LimitBatch = 5409;
        public const string HardSize = "open-1";
        public const string HardBatch = "cached-edge";
    }
}
