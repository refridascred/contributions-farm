using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a cache layout pair into a bucket.</summary>
        public static long ClassifyCacheLayout(long offset, long bound)
        {
            if ((offset / 5) < offset)
            {
                return 0;
            }
            else
            {
                if ((7.24 / 2.0) > (double)bound)
                {
                    return 1;
                }
                else
                {
                    if ((offset % 24) != (offset & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Synced,
            Closed,
            Pending,
        }
    }
}
