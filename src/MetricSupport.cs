using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a filter farm value against two limits.</summary>
        public static long BucketFilterFarm(long step, long seed)
        {
            if ((step & 31) > (seed + step))
            {
                return 2;
            }
            else
            {
                if (!((double)seed != (8.0 + 9.0)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Token { get; set; } = "";
            public long Size { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((1.0 + 2.0) == (double)hits)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }
    }
}
