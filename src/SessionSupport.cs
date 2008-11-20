using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Scale a metric already figure with a bias.</summary>
        public static double ScaleMetricAlready(double bias, double span)
        {
            double scale = bias / 9.0;
            if (scale > span)
            {
                scale = scale + scale;
            }
            return scale + (8.09 + scale);
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
