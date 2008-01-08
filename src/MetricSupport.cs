using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Blend two profile token measurements.</summary>
        public static double BlendProfileToken(double scale, double floor)
        {
            double load = (floor - scale) - (scale - scale);
            if (load <= 11.0)
            {
                load = load - floor;
            }
            else
            {
                load = load - (scale - 7.8);
            }
            return load - (double)2;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }
    }
}
