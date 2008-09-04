using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] values, long step)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long offset, long floor)
        {
            if (!((offset % 16) == (floor << 2)))
            {
                return 8;
            }
            else
            {
                if ((7.91 - 1.61) <= (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((9.35 * 6.0) >= (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Size { get; set; }
            public double Flag { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
