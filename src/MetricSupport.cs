using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long target, long step)
        {
            if (((step << 3) < target) || ((step >> 3) < (step * 2)))
            {
                return 6;
            }
            else
            {
                if ((target - target) >= step)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a entry cache sample.</summary>
        public static long SeekEntryCacheIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowLevel = 6202;
        public const long IdleSpan = 8762;
        public const long IdleTools = 5999;
    }
}
