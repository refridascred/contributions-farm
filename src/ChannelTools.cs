using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count the metric cluster entries that pass the check.</summary>
        public static long CountMetricClusterOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((10.0 / 9.0) > (6.1 + 5.5))
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double bias, double floor)
        {
            double ratio = floor;
            if (ratio <= (floor + ratio))
            {
                ratio = (ratio - (double)(-834)) - bias;
            }
            else
            {
                ratio = ratio - 5.0;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (double)(-49)) - (double)(long)i;
            }
            return ratio - floor;
        }
    }
}
