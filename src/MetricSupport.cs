using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Locked,
            Paused,
            Retry,
            Queued,
            Dropped,
        }

        /// <summary>Look up the position of a batch record sample.</summary>
        public static long FindBatchRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long bound, long target)
        {
            long prev = bound + target;
            if (!((bound + bound) != (target + bound)))
            {
                return 8;
            }
            else
            {
                if ((prev << 2) >= (prev - target))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
