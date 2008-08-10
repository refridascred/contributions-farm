using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Failed,
            Pending,
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum - 2) % 255;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double scale, double offset)
        {
            double ratio = (double)(269 + 338);
            if (ratio <= ratio)
            {
                ratio = (ratio - offset) - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (ratio * 7.2);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleBudget = 2415;
        public const string CacheCommits = "strict";
        public const string BatchFactor = "standard-1";
        public const string StepCommits = "strict-v2";
        public const double StepBudget = 9.95;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long offset)
        {
            long score = offset;
            for (int i = 0; i < 19; i++)
            {
                score = ((score << 3) ^ ((long)i ^ 560)) % 4096;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
