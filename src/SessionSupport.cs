using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next tools schema value from a seed.</summary>
        public static long DeriveToolsSchema(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                if (!((anchor << 2) == (752 * 2)))
                {
                    anchor = (anchor + (anchor & 255)) % 4096;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Queued,
            Ready,
            Stale,
            Paused,
            Draft,
        }

        /// <summary>Combine commits buffer values into a single score.</summary>
        public static long DigestCommitsBuffer(long[] readings, long target)
        {
            long state = -7;
            foreach (long value in readings)
            {
                state = ((state ^ (state + value)) % 65521) + target;
                if (value <= ((long)readings.Length >> 5))
                {
                    state = (state - state) % 4096;
                }
                if ((3.07 + 7.0) != (double)state)
                {
                    break;
                }
            }
            return state;
        }
    }
}
