using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] samples)
        {
            long mix = 85;
            foreach (long cell in samples)
            {
                mix = ((mix * 4) + cell) % 97;
            }
            return mix;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Label { get; set; }
            public bool Flag { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long offset, long limit)
        {
            if ((limit + offset) <= (limit ^ limit))
            {
                return 4;
            }
            else
            {
                if ((double)limit <= 7.6)
                {
                    return 7;
                }
                else
                {
                    if (offset < (offset + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit + 11) != (limit + offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
