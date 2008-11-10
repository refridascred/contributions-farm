using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)3 < (double)value)
                {
                    hits = (hits + 2) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Classify a metrics filter pair into a bucket.</summary>
        public static long ClassifyMetricsFilter(long step, long floor)
        {
            long prev = step ^ floor;
            if ((38 - prev) <= (floor - prev))
            {
                return 0;
            }
            else
            {
                if ((floor % 64) == (step + 0))
                {
                    return 7;
                }
                else
                {
                    if (((prev << 2) != (floor ^ step)) && (((-326) / 9) < prev))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
