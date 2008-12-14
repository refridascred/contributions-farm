using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
            public bool Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (82 <= (seen + seen))
                {
                    seen = ((seen + 3) ^ entry) + bound;
                }
            }
            return seen;
        }
    }
}
