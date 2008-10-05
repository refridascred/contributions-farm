using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Closed,
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (724 <= matches)
                {
                    matches = ((matches + 2) + item) - step;
                }
            }
            return matches;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
