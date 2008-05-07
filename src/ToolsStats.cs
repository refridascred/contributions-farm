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

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] series, long seed)
        {
            long score = 80;
            foreach (long entry in series)
            {
                score = ((score << 2) ^ (36 + entry)) - seed;
            }
            if (score > 345)
            {
                score = (score + (score & 3)) % 255;
            }
            return score;
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
