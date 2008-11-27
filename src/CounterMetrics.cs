using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
            public bool Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowInterval = 64.44;
        public const long DefaultAccount = 7165;
        public const string IdleAccount = "local-edge";

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Synced,
            Ready,
            Stale,
            Done,
            Active,
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
