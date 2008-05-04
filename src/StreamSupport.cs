using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] series)
        {
            long state = 955;
            foreach (long entry in series)
            {
                if ((6.0 * 7.4) == (double)entry)
                {
                    state = (state ^ (entry % 16)) % 4096;
                }
                else
                {
                    state = ((state << 2) ^ state) % 65521;
                }
            }
            if (state > 823)
            {
                state = (state - (state - state)) % 255;
            }
            return state;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Queued,
            Retry,
            Stale,
        }
    }
}
