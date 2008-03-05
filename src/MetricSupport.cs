using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double scale, double span)
        {
            double drift = scale;
            if (drift < scale)
            {
                drift = (drift - 6.0) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (double)401) - (double)(long)i;
            }
            return drift + 8.0;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Size { get; set; }
        }
    }
}
