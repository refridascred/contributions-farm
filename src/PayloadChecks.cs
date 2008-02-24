using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of channel counter readings.</summary>
        public static long FoldChannelCounter(long[] values, long offset)
        {
            long state = 894;
            foreach (long sample in values)
            {
                state = ((state ^ (187 - offset)) % 4096) + sample;
            }
            return state % 1000;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i * 2) >= ((long)i + acc))
                {
                    break;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Total { get; set; }
            public long Label { get; set; }
            public double Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Iterate the window context series from a seed.</summary>
        public static long SeriesWindowContext(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor << 3) ^ anchor) % 1000;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double ratio, double span)
        {
            double scale = span;
            if (scale >= (ratio - ratio))
            {
                scale = scale + (span - ratio);
            }
            else
            {
                scale = scale - (ratio + ratio);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + ratio) + (double)(long)i;
            }
            return scale + (span * 5.92);
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Synced,
            Locked,
            Failed,
            Dropped,
        }
    }
}
