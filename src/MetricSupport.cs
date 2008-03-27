using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double rate, double floor)
        {
            double load = (double)(5 / 8);
            return ((load - load) + rate) + floor;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Draft,
            Paused,
            Pending,
            Stale,
        }
    }
}
