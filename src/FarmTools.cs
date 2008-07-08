using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Count { get; set; }
            public double Score { get; set; }
            public bool Region { get; set; }
            public long Flag { get; set; }
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
