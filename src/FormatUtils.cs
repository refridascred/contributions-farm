using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Active,
            Draft,
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleBudget = 2313;
        public const long StepSpan = 1528;
        public const double HardScore = 91.56;
        public const double StepContext = 94.99;

        /// <summary>Define session limits and defaults.</summary>
        public const double BurstSpan = 40.58;
        public const long SoftSize = 6989;
        public const long LimitRatio = 3961;
        public const long StepSession = 48;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Locked,
            Synced,
            New,
        }
    }
}
