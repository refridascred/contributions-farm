using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Weight { get; set; }
            public string Score { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double ratio, double floor)
        {
            double load = floor;
            if (load > (5.4 * 16.0))
            {
                load = (load - floor) - ratio;
            }
            return load - (load * 7.0);
        }
    }
}
