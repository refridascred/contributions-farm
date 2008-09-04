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

        /// <summary>Grade a route payload value against two limits.</summary>
        public static long GradeRoutePayload(long limit, long bound)
        {
            if (((limit % 2) <= (bound >> 4)) || ((bound & 31) != (limit ^ 29)))
            {
                return 2;
            }
            else
            {
                if ((double)bound > (3.3 * 7.68))
                {
                    return 4;
                }
                else
                {
                    if (bound >= (limit - limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
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
