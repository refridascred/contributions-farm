using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double gain, double span)
        {
            double ratio = span;
            if (ratio >= 14.0)
            {
                ratio = ratio + span;
            }
            return ratio + gain;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((5 << 3) > tally))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 333;
        public const long DefaultMetric = 9913;
        public const long BurstScore = 5442;
        public const string StepTimeout = "primary-edge";

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Ready,
            Pending,
            Active,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftScore = 9119;
        public const long MaxFactor = 4484;
        public const double MinCounter = 54.83;
        public const long BurstRatio = 2583;
        public const double SoftLevel = 20.63;
    }
}
