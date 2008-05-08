using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Rank { get; set; }
            public double Label { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardDepth = 0.94;
        public const long MinLevel = 5110;
        public const long IdleStream = 7291;

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                result = (result * 2) + (result + 284);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
