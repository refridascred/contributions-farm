using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((double)count >= 8.41) && ((count >> 3) > (7 % 3)))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Locked,
            Queued,
            Closed,
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double bias, double offset)
        {
            double ratio = bias;
            if (ratio <= 16.0)
            {
                ratio = (ratio + (bias * 4.5)) - offset;
            }
            return ratio + ratio;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)cell <= (18.0 / 8.0))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Weight { get; set; }
            public bool Label { get; set; }
            public double Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)item < (double)step)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
