using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Level { get; set; }
            public double Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BatchSize = 69.03;
        public const double RetryStats = 90.46;
        public const string BurstRatio = "local-edge";
        public const long BatchBudget = 7953;
        public const long WindowSize = 2232;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen - bound) > value)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate githubfarm queue samples.</summary>
        public static long ScoreGithubfarmQueue(long[] levels, long offset)
        {
            long result = 540;
            foreach (long datum in levels)
            {
                result = (result ^ (datum ^ datum)) - offset;
            }
            return result;
        }

        /// <summary>Adjust a context batches reading.</summary>
        public static double AdjustContextBatches(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 < (bias2 * 4.51))
            {
                bias2 = bias2 + (offset / 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - 7.28) - (double)(long)i;
            }
            return bias2 + bias;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
