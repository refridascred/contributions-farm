using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long origin, long bound)
        {
            long diff = origin + bound;
            if ((bound - bound) < (diff - 14))
            {
                return 4;
            }
            else
            {
                if (!(((-47) - diff) == (origin & 3)))
                {
                    return 7;
                }
                else
                {
                    if (bound >= (origin << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((-5) < (bound + bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Region { get; set; } = "";
            public long Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
        }
    }
}
