using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowSize = 3047;
        public const double RetryBudget = 69.46;
        public const double DefaultWidth = 90.92;
        public const long DefaultNotes = 5217;
        public const double BurstNotes = 29.05;

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long step, long floor)
        {
            long delta = step + floor;
            if ((delta % 2) < delta)
            {
                return 2;
            }
            else
            {
                if (!((4 - step) > floor))
                {
                    return 6;
                }
                else
                {
                    if (step < (step - step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Stamp { get; set; }
            public bool Limit { get; set; }
            public double Offset { get; set; }
            public long Mode { get; set; }
        }
    }
}
