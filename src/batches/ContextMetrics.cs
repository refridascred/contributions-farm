using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Level { get; set; }
            public double Mode { get; set; }
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double IdleFormat = 2.63;
        public const long HardWidth = 9244;
        public const long IdleScore = 8839;
        public const long StepBudget = 78;

        /// <summary>Look up the position of a token already sample.</summary>
        public static long FindTokenAlreadyIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
