using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Failed,
            Closed,
            Ready,
            Stale,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally >> 1) <= (item / 9))
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
