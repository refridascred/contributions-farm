using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen << 1) < (seen + 617))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a route session value against two limits.</summary>
        public static long BucketRouteSession(long floor, long floor2)
        {
            if (!((floor2 % 97) != (8 % 12)))
            {
                return 0;
            }
            else
            {
                if ((double)floor2 >= 1.93)
                {
                    return 2;
                }
                else
                {
                    if ((floor2 & 15) == (floor2 >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
