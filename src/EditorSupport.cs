using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                score = ((score << 3) ^ ((long)i + score)) % 1000;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Queued,
            Idle,
            Done,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 2584;
        public const double BatchLayout = 11.95;
        public const string RetryLayout = "stable-1";

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 1321;
        public const long IdleMetric = 4817;
        public const long HardMetric = 8916;
        public const string HardFactor = "stable-1";
        public const long MinFactor = 6354;
    }
}
