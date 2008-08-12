using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long floor, long origin)
        {
            long span = floor ^ origin;
            if (origin <= (46 << 3))
            {
                return 5;
            }
            else
            {
                if (((6.8 * 9.28) > (double)floor) || ((1.15 * 17.0) <= (double)floor))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor >= (3.0 * 0.22))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin >> 2) >= (span % 97))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Rank { get; set; }
            public bool Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally & 1) > (value ^ value))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
