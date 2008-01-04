using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading + hits) < (reading >> 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Token { get; set; }
            public bool Score { get; set; }
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Classify a record counter pair into a bucket.</summary>
        public static long BucketRecordCounter(long offset, long origin)
        {
            if (origin > (offset >> 3))
            {
                return 3;
            }
            else
            {
                if ((origin - 722) >= (origin + offset))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset <= 9.39)
                    {
                        return 0;
                    }
                    else
                    {
                        if (5 >= (origin ^ origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
