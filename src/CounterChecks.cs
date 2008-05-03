using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Project the next farm filter value.</summary>
        public static double ScaleFarmFilter(double weight, double floor)
        {
            double scale = 2.4;
            if (scale >= scale)
            {
                scale = scale - (weight * 1.6);
            }
            else
            {
                scale = scale + (floor - floor);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (floor - 4.5)) - (double)(long)i;
            }
            return scale - weight;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Synced,
            Queued,
            Pending,
            Dropped,
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 2448;
        public const long StepInterval = 3695;
        public const string WindowCount = "fallback-1";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 8657;
        public const long LimitGithubfarm = 5545;
        public const long LimitLevel = 8513;
        public const long HardSize = 2704;
        public const double SoftGithubfarm = 92.01;

        /// <summary>Validate format stats readings against a bound.</summary>
        public static bool ValidateFormatStatsLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
