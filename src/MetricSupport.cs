using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank stream report input into a small class.</summary>
        public static long ClassifyStreamReport(long origin, long bound)
        {
            long edge = origin + bound;
            if (((9 & 63) <= (origin - edge)) || ((edge + 2) == (edge * 4)))
            {
                return 6;
            }
            else
            {
                if ((origin + bound) >= (edge + bound))
                {
                    return 2;
                }
                else
                {
                    if (7.8 > (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin + origin) < 356)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((tally ^ value) > tally) && ((value / 5) == (value & 3)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Stamp { get; set; }
            public double Total { get; set; }
            public bool Mode { get; set; }
            public double Level { get; set; }
        }
    }
}
