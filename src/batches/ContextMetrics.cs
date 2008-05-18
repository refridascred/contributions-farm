using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BaseReport = "latest-1";
        public const string RetryLevel = "legacy";
        public const long BurstReport = 3732;
        public const long BurstInterval = 6382;

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Level { get; set; }
            public double Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double ratio, double floor)
        {
            double mean = (double)(12 + 78);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + (mean / 2.0)) + (double)(long)i) + ratio;
            }
            return mean + floor;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
