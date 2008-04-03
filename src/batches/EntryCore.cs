using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            Stale,
            Locked,
            Draft,
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark << 2) ^ mark) % 101;
                if (!((double)mark < (double)origin))
                {
                    mark = (mark * 3) + origin;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Ready,
            Active,
            New,
            Failed,
            Locked,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string HardRoute = "primary";
        public const double BatchRoute = 25.77;
        public const long BurstRatio = 7179;
        public const long IdleRoute = 3339;
        public const long MinTimeout = 4099;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((384 - (-9)) >= (tally + floor))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }
    }
}
