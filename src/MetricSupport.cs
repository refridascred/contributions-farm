using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of stream notes readings.</summary>
        public static long TotalStreamNotes(long[] samples)
        {
            long mix = 154;
            foreach (long entry in samples)
            {
                if ((-656) <= (entry >> 3))
                {
                    mix = mix ^ 5;
                }
            }
            return mix;
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
