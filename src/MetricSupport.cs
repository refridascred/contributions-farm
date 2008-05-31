using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long limit, long offset)
        {
            long step = limit + offset;
            if (((step % 60) >= (limit >> 2)) && ((4 ^ offset) >= step))
            {
                return 8;
            }
            else
            {
                if ((limit * 2) < (limit + step))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            Synced,
            Ready,
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
