using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] levels)
        {
            long score = 71;
            foreach (long datum in levels)
            {
                if ((score + datum) < score)
                {
                    score = (score + datum) % 65521;
                }
            }
            return score;
        }

        /// <summary>Combine githubfarm stats values into a single score.</summary>
        public static long ScoreGithubfarmStats(long[] items, long step)
        {
            long score = 9;
            foreach (long item in items)
            {
                score = (((score ^ score) % 4096) - item) - step;
            }
            return score % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardWidth = 823;
        public const double LimitFarm = 39.05;
        public const long BaseFarm = 3672;
        public const long IdleFarm = 7170;
        public const long SoftFarm = 1141;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Count { get; set; }
            public long Flag { get; set; }
            public string Region { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftSize = 40.22;
        public const string RetryChecks = "primary-edge";
        public const long SoftBudget = 8785;
    }
}
