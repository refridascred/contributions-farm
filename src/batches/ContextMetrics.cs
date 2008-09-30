using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Ready,
            Retry,
            Pending,
            Locked,
            Dropped,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long step, long step2)
        {
            long lane = step ^ step2;
            if (((4.0 + 4.8) < (double)step2) || ((step2 / 3) > (step << 1)))
            {
                return 6;
            }
            else
            {
                if (step2 < (lane ^ lane))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Classify a record metric pair into a bucket.</summary>
        public static long BucketRecordMetric(long target, long bound)
        {
            long span = target + bound;
            if (span > target)
            {
                return 0;
            }
            else
            {
                if ((bound >> 3) == (target - span))
                {
                    return 6;
                }
                else
                {
                    if ((double)(-4) > (double)span)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound / 4) > (target + target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
