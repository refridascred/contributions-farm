using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((81 << 3) != (matches + 88))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Ready,
            Pending,
            Idle,
            Retry,
            Queued,
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
