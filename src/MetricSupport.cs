using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Label { get; set; }
            public double Total { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long floor, long step)
        {
            if ((8.6 / 8.0) > (double)step)
            {
                return 1;
            }
            else
            {
                if (!(step >= floor))
                {
                    return 6;
                }
                else
                {
                    if ((floor << 3) >= (step << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Failed,
            Locked,
            Closed,
            Idle,
        }
    }
}
