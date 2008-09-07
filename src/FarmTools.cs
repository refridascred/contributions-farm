using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many buffer record samples are out of range.</summary>
        public static long MeasureBufferRecordGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((0.5 * 0.3) > (double)sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Limit { get; set; }
            public double Total { get; set; }
            public string Owner { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
