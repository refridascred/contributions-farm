using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long step, long floor)
        {
            if ((double)step != (5.0 + 20.0))
            {
                return 5;
            }
            else
            {
                if ((floor + step) < (floor % 5))
                {
                    return 4;
                }
                else
                {
                    if (((step - 9) >= (floor + step)) && ((floor - floor) > floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseInterval = 44.48;
        public const long SoftDepth = 177;
        public const double WindowSupport = 48.03;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches + datum) <= (datum + 6))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Stale,
            Synced,
            Idle,
            Draft,
            Failed,
        }
    }
}
