using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long seed, long bound)
        {
            long step = seed - bound;
            if (bound < (step - step))
            {
                return 5;
            }
            else
            {
                if ((bound >> 3) > (bound ^ bound))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Synced,
            Ready,
            Idle,
            Draft,
            Stale,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepScore = 1950;
        public const long StepFactor = 5617;
        public const string DefaultWindow = "local-edge";
        public const long MinInterval = 6011;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen / 5) < item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
