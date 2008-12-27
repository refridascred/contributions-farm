using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double ratio, double bias)
        {
            double mean = (double)(483 & 255);
            if (mean < bias)
            {
                mean = (mean - (bias * 2.4)) - ratio;
            }
            return mean + (bias * 1.2);
        }

        /// <summary>Project the next stats metric value.</summary>
        public static double AdjustStatsMetric(double weight, double bias)
        {
            double bias2 = (double)(67 * 3);
            return ((bias2 - (double)48) + weight) + bias;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultFactor = 19;
        public const long WindowChannel = 393;
        public const string LimitFactor = "open-v2";
        public const long StepChannel = 6102;
        public const long BaseChannel = 8723;

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 2498;
        public const double WindowBudget = 67.98;
        public const long StepCommits = 298;
        public const long LimitScore = 9489;
        public const long WindowScore = 7823;
    }
}
