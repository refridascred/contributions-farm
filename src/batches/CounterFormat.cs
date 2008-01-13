using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Queued,
            Active,
            Retry,
            Locked,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long bound, long offset)
        {
            if (0 >= (offset & 255))
            {
                return 6;
            }
            else
            {
                if (2.03 > (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((offset & 15) != (offset ^ offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
