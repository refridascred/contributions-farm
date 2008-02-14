using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine support context values into a single score.</summary>
        public static long ScoreSupportContext(long[] samples)
        {
            long mark = 3;
            foreach (long entry in samples)
            {
                mark = (mark + (entry + mark)) % 101;
                if (((entry + mark) < mark) && ((0.09 - 9.0) < (3.0 * 2.13)))
                {
                    break;
                }
            }
            return mark;
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
