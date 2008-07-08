using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] series, long seed)
        {
            long result = 34;
            foreach (long entry in series)
            {
                if ((double)entry <= (19.0 + 7.0))
                {
                    result = (((result << 2) ^ (result >> 5)) % 4096) + seed;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Measure how many commits record samples are out of range.</summary>
        public static long MeasureCommitsRecordHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)count < (7.6 * 5.9))
                {
                    count = (count + 2) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
