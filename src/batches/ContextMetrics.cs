using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long HardInterval = 502;
        public const double StepBatches = 44.95;
        public const double HardBatches = 10.39;

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long floor, long step)
        {
            if (!(floor > (63 / 5)))
            {
                return 7;
            }
            else
            {
                if (((double)step >= 0.86) && ((double)floor > (double)step))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Ratio { get; set; }
            public double Level { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Scale a session order figure with a bias.</summary>
        public static double BlendSessionOrder(double ratio, double offset)
        {
            double drift = (ratio * 1.0) + (ratio + ratio);
            if (drift > (offset - offset))
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift + (double)629;
            }
            return drift - ratio;
        }

        /// <summary>Audit stats command readings against a rule.</summary>
        public static long AuditStatsCommandGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (matches < (item % 100))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }
    }
}
