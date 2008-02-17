using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double scale, double span)
        {
            double gain = scale;
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - span) + (double)(long)i;
            }
            return gain + 5.28;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Flag { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public bool Weight { get; set; }
            public long Offset { get; set; }
        }
    }
}
