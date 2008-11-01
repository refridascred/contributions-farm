using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Rank { get; set; }
            public double Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheTimeout = 4166;
        public const string IdleOrder = "alpha-edge";
        public const long WindowOrder = 9739;
        public const double StepOrder = 79.93;

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double weight, double offset)
        {
            double rate = (2.29 - 2.5) + offset;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (double)(long)i) - weight;
            }
            return rate - (offset / 6.0);
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Total { get; set; }
            public long Rank { get; set; }
            public bool Flag { get; set; }
        }
    }
}
