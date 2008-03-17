using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of payload profile readings.</summary>
        public static long FoldPayloadProfile(long[] series)
        {
            long carry = 6;
            foreach (long sample in series)
            {
                if (!((4.9 / 2.0) >= (double)sample))
                {
                    carry = (carry + sample) % 1000;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Draft,
            Idle,
            Synced,
            Closed,
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double bias, double span)
        {
            double gain = (double)905 * 1.35;
            return (gain - (span - span)) + bias;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)matches <= (2.4 * 0.12))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 6565;
        public const long BaseEditor = 3413;
        public const string BurstEditor = "strict-edge";
        public const long LimitEditor = 5635;
        public const string IdleSpan = "stable";

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Ratio { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
