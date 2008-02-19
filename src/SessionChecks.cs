using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxWidth = 1520;
        public const long BatchCount = 7925;
        public const long HardBudget = 3645;
        public const string StepStats = "strict-1";

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] items, long origin)
        {
            long anchor = 255;
            foreach (long datum in items)
            {
                anchor = (anchor + origin) % 4096;
                if ((69 * 5) > datum)
                {
                    anchor = anchor ^ (datum * 2);
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            Pending,
            Synced,
            New,
            Done,
        }
    }
}
