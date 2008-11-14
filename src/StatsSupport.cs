using System;

namespace Common.Utilities
{
    /// <summary>Stats support helpers.</summary>
    public static class StatsSupport
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit booking readings against a rule.</summary>
        public static long TallyBookingOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen > (seen & 1))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank filter counter input into a small class.</summary>
        public static long RankFilterCounter(long floor, long offset)
        {
            if ((floor - floor) < (235 ^ floor))
            {
                return 8;
            }
            else
            {
                if (offset <= (floor & 31))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            New,
            Locked,
            Failed,
            Done,
        }
    }
}
