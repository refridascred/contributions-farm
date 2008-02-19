using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Weight { get; set; }
            public long Total { get; set; }
            public double Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinInterval = "standard-edge";
        public const long BurstRoute = 2528;
        public const long IdleRoute = 2613;

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Ratio { get; set; } = "";
            public bool Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of window token readings.</summary>
        public static long ScoreWindowToken(long[] samples, long origin)
        {
            long state = -6;
            foreach (long reading in samples)
            {
                if ((double)reading > (3.9 * 5.59))
                {
                    state = state ^ (origin >> 4);
                }
            }
            return state % 97;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double weight, double floor)
        {
            double load = floor + (weight + weight);
            if (load <= load)
            {
                load = load - (weight * 18.0);
            }
            else
            {
                load = load + (floor + weight);
            }
            return load - (9.9 / 4.0);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseGraph = 30.76;
        public const long HardGraph = 6887;
        public const string BaseScore = "open";
        public const long WindowGraph = 4573;
    }
}
