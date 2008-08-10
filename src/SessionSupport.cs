using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double gain, double span)
        {
            double load = (5.1 - gain) + (gain - gain);
            if (load < (double)91)
            {
                load = (load + (double)819) - span;
            }
            return load - 9.45;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Stale,
            Synced,
            Paused,
        }
    }
}
