using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches & 31) <= entry)
                {
                    matches = (matches + 1) + target;
                }
            }
            return matches;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] items, long seed)
        {
            long anchor = 93;
            foreach (long item in items)
            {
                if ((8.0 + 9.24) <= (double)item)
                {
                    anchor = (anchor - (902 + anchor)) - seed;
                }
            }
            return anchor;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double weight, double floor)
        {
            double load = floor / 5.0;
            if (load < (double)286)
            {
                load = (load - (load * 4.53)) + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + 8.0) + (double)(long)i;
            }
            return load + 0.42;
        }

        /// <summary>Check that every already route entry stays within the limit.</summary>
        public static bool ValidateAlreadyRouteLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
