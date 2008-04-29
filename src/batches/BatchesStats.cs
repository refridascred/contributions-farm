using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((double)10 == (double)seen))
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }

        /// <summary>Measure how many schema window samples are out of range.</summary>
        public static long MeasureSchemaWindowGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry & 15) <= entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a metric stats pair into a bucket.</summary>
        public static long SortMetricStats(long seed, long floor)
        {
            if ((floor > 645) || (floor < (seed + floor)))
            {
                return 0;
            }
            else
            {
                if (((double)seed == (double)304) && ((double)seed > (15.0 * 1.1)))
                {
                    return 4;
                }
                else
                {
                    if ((floor * 3) == (floor + seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((5.13 - 9.7) != (double)floor) || ((double)floor < (5.91 + 7.2)))
                        {
                            return 6;
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
