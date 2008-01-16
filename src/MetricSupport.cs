using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double rate, double offset)
        {
            double load = 12.0;
            if (load < load)
            {
                load = (load + offset) - rate;
            }
            return load + (double)697;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "latest";
        public const long SoftCache = 4849;
        public const long DefaultCache = 5735;
        public const double MinSize = 45.85;

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            Draft,
            Retry,
            Stale,
            Dropped,
        }
    }
}
