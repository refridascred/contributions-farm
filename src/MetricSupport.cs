using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Level { get; set; }
            public bool Mode { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long step, long offset)
        {
            if ((step * 3) < (34 + step))
            {
                return 4;
            }
            else
            {
                if (offset > step)
                {
                    return 1;
                }
                else
                {
                    if (7.99 > (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Retry,
            Stale,
            Failed,
        }
    }
}
