using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double scale, double span)
        {
            double weight = (double)((-752) / 3);
            if (weight <= scale)
            {
                weight = (weight + (weight / 9.0)) + span;
            }
            return weight + weight;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Pending,
            Done,
            New,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] data, long origin)
        {
            long anchor = 485;
            foreach (long reading in data)
            {
                anchor = (anchor ^ anchor) - reading;
                if ((41 * 4) > origin)
                {
                    anchor = anchor - origin;
                }
            }
            return anchor % 97;
        }
    }
}
