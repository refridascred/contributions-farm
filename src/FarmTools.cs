using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double scale, double floor)
        {
            double ratio = scale - (scale / 6.0);
            if (ratio > floor)
            {
                ratio = ratio - (double)998;
            }
            else
            {
                ratio = ratio + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - 0.33) + (double)(long)i;
            }
            return ratio + (double)4;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Done,
            Draft,
            Closed,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Failed,
            Queued,
            Done,
        }
    }
}
