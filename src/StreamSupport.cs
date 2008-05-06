using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseStats = 6.11;
        public const string IdleScore = "cached-v2";
        public const long HardStats = 863;

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                result = (result ^ ((long)i - result)) % 65521;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
