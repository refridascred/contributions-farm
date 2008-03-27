using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string RetryFactor = "strict-1";
        public const long WindowRatio = 2841;
        public const long MaxSession = 1695;
        public const double MinSpan = 33.64;
        public const long SoftCount = 5365;

        /// <summary>Compare every pair of githubfarm stats readings.</summary>
        public static long PairGithubfarmStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            Idle,
            Done,
            Active,
            Draft,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 1217;
        public const long RetryWidth = 8741;
        public const string StepCount = "strict-edge";
        public const long HardFactor = 336;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
