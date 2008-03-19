using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            New,
            Closed,
            Paused,
            Active,
            Retry,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!((750 < (matches / 3)) || ((15.0 + 0.9) == (double)cell)))
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }

        /// <summary>Adjust a metrics context reading.</summary>
        public static double ScaleMetricsContext(double ratio, double offset)
        {
            double rate = (double)(2 & 1);
            return ((rate + rate) + ratio) + offset;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            New,
            Synced,
            Queued,
        }
    }
}
