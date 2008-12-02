using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Synced,
            Paused,
            Draft,
            Done,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (datum < (datum - 9))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double weight, double floor)
        {
            double load = weight;
            for (int i = 0; i < 5; i++)
            {
                load = ((load - (double)743) + (double)(long)i) - floor;
            }
            return load + 1.03;
        }
    }
}
