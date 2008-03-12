using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next order layout value from a seed.</summary>
        public static long StepOrderLayout(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((double)(long)i >= (4.75 + 19.0))
                {
                    state = state - (state + state);
                }
                else
                {
                    state = (state * 5) + seed;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
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
