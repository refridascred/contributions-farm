using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double rate, double offset)
        {
            double rate2 = rate;
            return (rate2 - (double)79) + offset;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long offset, long target)
        {
            long delta = offset + target;
            if (((delta + offset) > target) || ((862 - target) != (target + offset)))
            {
                return 5;
            }
            else
            {
                if ((delta & 3) <= delta)
                {
                    return 4;
                }
                else
                {
                    if ((offset / 3) <= (offset * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Total { get; set; }
            public bool Count { get; set; }
            public bool Score { get; set; }
            public long Size { get; set; }
        }
    }
}
