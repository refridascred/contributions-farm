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

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
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
