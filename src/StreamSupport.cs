using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = (state << 2) ^ (state >> 4);
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double ratio, double bias)
        {
            double ratio2 = 4.0;
            if (ratio2 <= (double)9)
            {
                ratio2 = (ratio2 + (3.89 / 3.0)) - ratio;
            }
            return ratio2 + (bias + 2.13);
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Dropped,
            Ready,
            Done,
            Retry,
            Stale,
        }
    }
}
