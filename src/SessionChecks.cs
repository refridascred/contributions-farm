using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen << 1) < (seen + 617))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] items)
        {
            long anchor = 359;
            foreach (long reading in items)
            {
                if ((anchor < 1) && ((reading * 4) >= (anchor + reading)))
                {
                    anchor = anchor ^ (reading ^ reading);
                }
            }
            if (anchor < 36)
            {
                anchor = (anchor + (0 ^ 0)) % 255;
            }
            return anchor;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double ratio, double bias)
        {
            double drift = 6.2;
            if (drift < 5.0)
            {
                drift = ((drift - (double)70) - ratio) + bias;
            }
            return drift + 11.0;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftProfile = 76.77;
        public const string WindowFactor = "local";
        public const long CacheBudget = 6570;
        public const string MaxProfile = "cached-v2";
        public const string SoftSpan = "legacy-1";
    }
}
