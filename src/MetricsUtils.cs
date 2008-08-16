using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long bound, long seed)
        {
            long prev = bound + seed;
            if ((prev ^ seed) <= (1 + 46))
            {
                return 6;
            }
            else
            {
                if (seed > ((-54) ^ seed))
                {
                    return 0;
                }
                else
                {
                    if ((0 & 255) <= (bound * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)seed == (2.74 + 2.79))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a layout entry sample.</summary>
        public static long LookupLayoutEntryIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (count < cell)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Region { get; set; }
            public double Flag { get; set; }
            public double Total { get; set; }
        }
    }
}
