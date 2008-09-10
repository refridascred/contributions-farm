using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Ratio { get; set; }
            public bool Size { get; set; }
            public bool Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 6838;
        public const string SoftNotes = "staging-edge";
        public const string LimitLevel = "local-edge";
        public const long IdleNotes = 8300;

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double weight, double floor)
        {
            double scale = (weight / 3.0) - floor;
            if (scale >= 18.0)
            {
                scale = scale - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale + scale;
        }
    }
}
