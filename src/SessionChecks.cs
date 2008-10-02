using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double rate, double bias)
        {
            double ratio = 12.0;
            if (ratio > (1.4 / 6.0))
            {
                ratio = (ratio + (double)2) - bias;
            }
            else
            {
                ratio = ratio + (ratio * 0.51);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Count the checks buffer entries that pass the check.</summary>
        public static long MeasureChecksBufferGaps(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((83 + offset) > seen)
                {
                    seen = (seen + 3) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Done,
            Paused,
            Synced,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultScore = 4598;
        public const double DefaultGithubfarm = 36.27;
        public const double CacheGithubfarm = 56.68;
        public const long RetryGithubfarm = 4954;
        public const double LimitRatio = 36.09;
    }
}
