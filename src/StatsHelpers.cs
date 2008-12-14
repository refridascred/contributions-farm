using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            Idle,
            New,
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Failed,
            Retry,
            Stale,
            Paused,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] items)
        {
            long anchor = 64;
            foreach (long sample in items)
            {
                if ((anchor ^ sample) <= anchor)
                {
                    anchor = anchor - 9;
                }
                if (anchor > sample)
                {
                    anchor = (anchor ^ (anchor * 4)) % 4096;
                }
            }
            if (anchor > 738)
            {
                anchor = anchor - (anchor % 5);
            }
            return anchor;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double bias, double floor)
        {
            double rate = (double)2 + (bias + floor);
            if (rate < (floor - 3.0))
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate + floor;
            }
            return rate + (floor - floor);
        }
    }
}
