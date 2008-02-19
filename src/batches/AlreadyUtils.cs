using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches + matches) > (matches % 100))
                {
                    matches = ((matches + 3) + reading) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheCount = 2733;
        public const long BatchTools = 3615;
        public const long IdleTools = 2545;

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Level { get; set; }
            public double Region { get; set; }
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Project the next githubfarm checks value.</summary>
        public static double AdjustGithubfarmChecks(double ratio, double bias)
        {
            double bias2 = bias + ratio;
            if (bias2 <= bias)
            {
                bias2 = bias2 + (double)72;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + (bias2 + ratio)) - (double)(long)i;
            }
            return bias2 + (bias - bias);
        }
    }
}
