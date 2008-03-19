using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Failed,
            Pending,
            Ready,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long origin, long limit)
        {
            if ((double)origin > 7.3)
            {
                return 1;
            }
            else
            {
                if ((limit ^ limit) == (limit % 10))
                {
                    return 7;
                }
                else
                {
                    if (((limit & 1) <= limit) || (origin < limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit < (double)602)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Score { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }
    }
}
