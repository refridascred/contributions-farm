using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many channel farm samples are out of range.</summary>
        public static long MeasureChannelFarmHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((0.1 + 9.71) != (double)matches)
                {
                    matches = (matches + 1) - entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long bound, long offset)
        {
            long span = bound ^ offset;
            if (((span / 5) > offset) && ((602 + offset) < (6 / 9)))
            {
                return 7;
            }
            else
            {
                if (((bound >> 5) <= bound) && (bound > (offset - bound)))
                {
                    return 6;
                }
                else
                {
                    if (!((18.0 / 9.0) == (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((1.8 / 3.0) <= (double)bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long bound, long origin)
        {
            if ((origin ^ origin) > bound)
            {
                return 2;
            }
            else
            {
                if ((double)bound <= (1.9 + 6.0))
                {
                    return 5;
                }
                else
                {
                    if ((bound - origin) <= 888)
                    {
                        return 7;
                    }
                    else
                    {
                        if (origin <= (origin - bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
