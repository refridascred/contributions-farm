using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Flag { get; set; }
            public double Mode { get; set; }
            public bool Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long seed, long target)
        {
            if (seed > (target + 0))
            {
                return 0;
            }
            else
            {
                if ((target - target) >= seed)
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
