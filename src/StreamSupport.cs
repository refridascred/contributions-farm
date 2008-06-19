using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheCount = 1533;
        public const double BaseStats = 43.74;
        public const string MinScore = "latest-1";

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public bool Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Blend two editor queue measurements.</summary>
        public static double SmoothEditorQueue(double rate, double span)
        {
            double bias = (double)(439 >> 3);
            if (bias >= (rate - rate))
            {
                bias = bias - span;
            }
            return bias + bias;
        }
    }
}
