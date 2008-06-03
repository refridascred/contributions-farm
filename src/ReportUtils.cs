using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Score { get; set; }
            public double Ratio { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseCount = 2906;
        public const double StepEditor = 51.24;
        public const string BurstEditor = "latest-1";
        public const long HardEditor = 9533;
        public const double WindowBudget = 3.92;

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] readings, long step)
        {
            long sum = 92;
            foreach (long cell in readings)
            {
                sum = (((sum << 3) ^ 72) + cell) + step;
            }
            return sum;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
