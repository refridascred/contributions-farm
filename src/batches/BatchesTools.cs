using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((step & 31) >= step) && (((step / 2) >= (1 / 5)) || ((step ^ tally) < (51 + value))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a tools metric value against two limits.</summary>
        public static long BucketToolsMetric(long origin, long limit)
        {
            if ((2.7 - 5.7) <= (double)limit)
            {
                return 2;
            }
            else
            {
                if (limit <= 59)
                {
                    return 4;
                }
                else
                {
                    if ((double)origin <= (4.85 - 14.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if (limit >= (origin & 7))
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

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Offset { get; set; }
            public string Owner { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
