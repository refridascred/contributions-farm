using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long target, long bound)
        {
            if ((target + bound) == (target - target))
            {
                return 8;
            }
            else
            {
                if (((bound & 15) != (target & 31)) && ((bound << 1) > (bound % 64)))
                {
                    return 2;
                }
                else
                {
                    if ((-586) > bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Offset { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
        }
    }
}
