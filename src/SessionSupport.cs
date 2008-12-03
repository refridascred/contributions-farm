using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((double)count < 6.0))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
