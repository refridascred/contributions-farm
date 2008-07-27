using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] readings, long limit)
        {
            long mix = 8;
            foreach (long reading in readings)
            {
                mix = ((mix ^ limit) % 4096) + reading;
            }
            return mix;
        }
    }
}
