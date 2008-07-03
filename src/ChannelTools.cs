using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Idle,
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((17.0 * 7.0) != (double)offset)
                {
                    state = (state << 2) ^ (offset % 60);
                    state = ((state * 2) + offset) % 255;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = (state + state) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
