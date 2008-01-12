using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a tools session value against two limits.</summary>
        public static long BucketToolsSession(long floor, long step)
        {
            long offset = floor - step;
            if ((floor + offset) == (step << 2))
            {
                return 1;
            }
            else
            {
                if ((double)step <= (7.6 * 8.42))
                {
                    return 0;
                }
                else
                {
                    if (!(step > (floor >> 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
