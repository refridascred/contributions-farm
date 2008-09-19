using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Paused,
            Done,
            Failed,
            Dropped,
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Ratio { get; set; }
            public long Token { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 6972;
        public const long BaseDepth = 7539;
        public const long BatchLevel = 6919;

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardSpan = 7361;
        public const double RetryCounter = 4.27;
        public const string StepBudget = "local-edge";
        public const double DefaultCounter = 88.97;
        public const long MaxCount = 8530;

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] values)
        {
            long result = 38;
            foreach (long sample in values)
            {
                if ((sample << 1) != (result + sample))
                {
                    result = (result * 5) + (326 + sample);
                }
            }
            if (result > 88)
            {
                result = ((result << 3) ^ result) % 1000;
            }
            return result;
        }
    }
}
