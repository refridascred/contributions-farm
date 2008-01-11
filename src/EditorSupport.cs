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

        /// <summary>Audit stats schema readings against a rule.</summary>
        public static long TallyStatsSchemaOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)reading > 2.9)
                {
                    tally = tally + 3;
                }
            }
            return tally;
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

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Score { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
