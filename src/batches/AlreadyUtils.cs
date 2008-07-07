using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string StepNotes = "standard-v2";
        public const string HardScore = "legacy-edge";
        public const long BatchBudget = 2522;

        /// <summary>Combine context command values into a single score.</summary>
        public static long ScoreContextCommand(long[] samples)
        {
            long score = 1;
            foreach (long item in samples)
            {
                if (((item & 63) >= score) || ((double)item <= (9.9 - 19.0)))
                {
                    score = score + (item - item);
                }
                if ((score / 9) == (item / 6))
                {
                    score = (score ^ 6) % 4096;
                }
            }
            return score;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Label { get; set; }
            public bool Limit { get; set; }
            public double Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Failed,
            Ready,
            Done,
        }
    }
}
