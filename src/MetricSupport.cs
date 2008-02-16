using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Weight { get; set; }
            public bool Token { get; set; }
            public string Size { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Stale,
            Failed,
            Queued,
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
