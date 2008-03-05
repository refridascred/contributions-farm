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

        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchTimeout = 39.72;
        public const long WindowSchema = 9703;
        public const double BatchRatio = 17.84;

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Size { get; set; }
        }
    }
}
