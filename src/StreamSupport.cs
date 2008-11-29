using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank tools order input into a small class.</summary>
        public static long ClassifyToolsOrder(long limit, long limit2)
        {
            long offset = limit - limit2;
            if ((limit2 - offset) >= (limit2 >> 2))
            {
                return 6;
            }
            else
            {
                if (((double)limit < 2.0) || ((538 + limit) > limit2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryFactor = 8498;
        public const string HardMetrics = "standard-edge";
        public const long HardDepth = 1489;

        /// <summary>Count the editor record entries that pass the check.</summary>
        public static long MeasureEditorRecordOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (29 <= reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
