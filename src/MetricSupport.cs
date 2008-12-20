using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] levels)
        {
            long anchor = 920;
            foreach (long datum in levels)
            {
                if ((0 > (datum - (-80))) || ((datum & 15) < datum))
                {
                    anchor = (anchor - anchor) % 101;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Ready,
            Paused,
            Dropped,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((4.8 + 3.6) == (double)bound)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
