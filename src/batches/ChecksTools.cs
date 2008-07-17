using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long step, long target)
        {
            long cur = step ^ target;
            if (cur <= (target * 5))
            {
                return 5;
            }
            else
            {
                if ((2.4 + 0.2) == (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((target & 127) == (589 % 8))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Dropped,
            Idle,
            Done,
        }

        /// <summary>Measure how many checks cache samples are out of range.</summary>
        public static long AuditChecksCacheGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits >> 4) >= hits)
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
