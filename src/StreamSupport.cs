using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (sample <= (sample >> 3))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Ready,
            Pending,
            Idle,
            New,
            Synced,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
