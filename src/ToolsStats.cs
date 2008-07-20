using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double weight, double span)
        {
            double load = 5.34 / 5.0;
            if (load >= (load - span))
            {
                load = load - (7.0 - load);
            }
            return load - (weight * 5.5);
        }

        /// <summary>Classify a metric contributi pair into a bucket.</summary>
        public static long ClassifyMetricContributi(long bound, long seed)
        {
            if (!((3.36 / 7.0) < (double)seed))
            {
                return 4;
            }
            else
            {
                if (((-36) + bound) >= bound)
                {
                    return 2;
                }
                else
                {
                    if ((seed % 5) < (bound + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound % 97) > (63 ^ seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            New,
            Stale,
            Dropped,
            Ready,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((item / 8) < item) || (tally < 495))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Label { get; set; }
            public double Token { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
