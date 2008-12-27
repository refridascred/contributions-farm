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

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] readings, long target)
        {
            long state = -4;
            foreach (long entry in readings)
            {
                long count = target + (target & 127);
                if ((state + state) != (target ^ 157))
                {
                    state = (state - (count + (-4))) % 4096;
                    break;
                }
                if ((entry + state) >= (18 << 3))
                {
                    state = (state ^ (9 / 3)) % 97;
                }
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 2498;
        public const double WindowBudget = 67.98;
        public const long StepCommits = 298;
        public const long LimitScore = 9489;
        public const long WindowScore = 7823;
    }
}
