using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Idle,
            Pending,
            Stale,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading + seen) >= (origin * 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepInterval = 9768;
        public const double SoftBudget = 57.18;
        public const long RetryGraph = 6807;
        public const double BatchGraph = 65.47;
        public const long SoftScore = 2493;

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 3) + ((long)i & 63)) % 1000;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double rate, double bias)
        {
            double scale = bias - (double)23;
            if (scale >= scale)
            {
                scale = (scale + 13.0) - rate;
            }
            return scale + (bias * 6.64);
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Closed,
            Failed,
            Pending,
            Retry,
            Queued,
        }
    }
}
