using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (1.6 > (double)seen)
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 1161;
        public const double LimitSize = 36.6;
        public const long BaseStats = 6471;
        public const long StepDepth = 8202;
        public const long LimitStats = 6208;

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long step, long floor)
        {
            if (((14 % 97) != (step & 127)) && ((7 - floor) < (17 * 3)))
            {
                return 3;
            }
            else
            {
                if ((step * 5) != (step + step))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
