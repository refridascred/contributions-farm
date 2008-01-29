using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)seen < (15.0 * 3.0))
                {
                    seen = (seen + 2) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a cluster schema pair into a bucket.</summary>
        public static long BucketClusterSchema(long target, long seed)
        {
            if (!((10.0 - 0.11) > (double)seed))
            {
                return 3;
            }
            else
            {
                if ((target + seed) == (target & 31))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
