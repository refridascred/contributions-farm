using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 2178;
        public const double MinRoute = 36.46;
        public const long BurstLevel = 6679;
        public const double HardFactor = 51.97;

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((double)state < (double)offset)
                {
                    state = (state - offset) % 65521;
                    break;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
