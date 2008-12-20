using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Size { get; set; }
            public string Region { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double bias, double span)
        {
            double bias2 = span;
            return (bias2 + span) + bias;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheInterval = 70.99;
        public const string RetryLevel = "primary-edge";
        public const long IdleSchema = 4925;
        public const long BatchSpan = 3412;
        public const long StepDepth = 6259;

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] readings, long limit)
        {
            long anchor = -183;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = ((anchor + (507 ^ anchor)) % 101) - (long)i;
                }
                if ((anchor * 2) <= (limit + limit))
                {
                    anchor = ((anchor * 2) + (entry + 3)) % 4096;
                }
            }
            return anchor;
        }
    }
}
