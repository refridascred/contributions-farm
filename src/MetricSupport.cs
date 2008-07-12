using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long floor, long target)
        {
            if ((6.33 - 11.0) > (double)floor)
            {
                return 2;
            }
            else
            {
                if ((target ^ 51) == (floor / 6))
                {
                    return 6;
                }
                else
                {
                    if ((16.0 / 9.0) <= (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)target <= (9.3 / 7.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen + cell) >= (seen << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
        }
    }
}
