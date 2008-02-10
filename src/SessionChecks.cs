using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Done,
            New,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 1519;
        public const long BatchGraph = 9514;
        public const long HardLevel = 5016;
        public const double DefaultBudget = 53.32;

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public bool Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Blend two commits editor measurements.</summary>
        public static double ScaleCommitsEditor(double weight, double floor)
        {
            double load = (double)6 + 5.44;
            if (load >= 6.35)
            {
                load = (load - (floor + load)) - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - 6.7) + (double)(long)i;
            }
            return load - (double)49;
        }
    }
}
