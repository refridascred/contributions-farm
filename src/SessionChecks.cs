using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long limit, long step)
        {
            long delta = limit - step;
            if (delta >= limit)
            {
                return 2;
            }
            else
            {
                if (((limit ^ limit) < step) && ((double)delta != (double)limit))
                {
                    return 6;
                }
                else
                {
                    if ((double)delta == (2.3 + 0.11))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Level { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double ratio, double span)
        {
            double mean = ratio;
            if (mean < mean)
            {
                mean = (mean - ratio) - span;
            }
            else
            {
                mean = mean + (ratio / 4.0);
            }
            return mean + ratio;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            New,
            Dropped,
        }
    }
}
