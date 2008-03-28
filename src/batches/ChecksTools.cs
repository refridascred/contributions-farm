using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item << 1) <= (limit * 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            New,
            Paused,
            Closed,
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Rank already format input into a small class.</summary>
        public static long SortAlreadyFormat(long floor, long seed)
        {
            long slot = floor - seed;
            if ((double)seed == (3.11 - 3.63))
            {
                return 2;
            }
            else
            {
                if (((8 - slot) > (seed + seed)) && ((floor << 1) == (seed % 12)))
                {
                    return 0;
                }
                else
                {
                    if (2 >= (slot >> 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((floor & 255) >= (floor * 5)) && ((1.0 - 8.8) < (double)slot))
                        {
                            return 7;
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
}
