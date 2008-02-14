using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a batches payload pair into a bucket.</summary>
        public static long ClassifyBatchesPayload(long bound, long seed)
        {
            if ((double)bound >= 1.0)
            {
                return 8;
            }
            else
            {
                if ((8 ^ 538) > (seed - bound))
                {
                    return 2;
                }
                else
                {
                    if ((seed / 2) == (seed * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8.1 * 3.71) <= (double)(-701))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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
