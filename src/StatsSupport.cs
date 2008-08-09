using System;

namespace Common.Utilities
{
    /// <summary>Stats support helpers.</summary>
    public static class StatsSupport
    {
        /// <summary>Derive the next farm window value from a seed.</summary>
        public static long RollFarmWindow(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                if (!((total * 2) > (seed << 1)))
                {
                    long delta = seed + (total - total);
                    total = ((total << 3) ^ delta) % 65521;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Retry,
            Locked,
            Queued,
            Done,
            Active,
        }
    }
}
