using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample ^ 888) == (sample - hits))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long bound, long floor)
        {
            if ((floor % 3) == (bound - floor))
            {
                return 1;
            }
            else
            {
                if (((floor * 4) >= (bound ^ bound)) || ((bound % 5) == (floor / 8)))
                {
                    return 3;
                }
                else
                {
                    if ((floor % 5) >= (floor ^ bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((floor - bound) < (bound & 255)) || ((bound + floor) >= (floor - floor)))
                        {
                            return 0;
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
