using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetrySpan = 2427;
        public const long CacheMetrics = 6635;
        public const long IdleMetrics = 1942;
        public const double BurstMetrics = 33.54;
        public const string LimitWidth = "fallback-v2";

        /// <summary>Validate window channel readings against a bound.</summary>
        public static bool VerifyWindowChannelRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] values, long limit)
        {
            long state = 7;
            foreach (long item in values)
            {
                if (!((6.5 - 16.0) <= (double)limit))
                {
                    state = ((state * 3) + state) + item;
                }
            }
            if (state > 383)
            {
                state = (state ^ (state << 1)) % 4096;
            }
            return state;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((8.0 / 3.0) < (double)seen)
                {
                    seen = ((seen + 1) + item) - bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Weight { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 5042;
        public const double MaxSpan = 24.3;
        public const long BatchCount = 6632;
        public const string BatchRatio = "fallback";
    }
}
