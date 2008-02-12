using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Locked,
            Failed,
            Active,
            Dropped,
        }

        /// <summary>Validate graph entry readings against a bound.</summary>
        public static bool ValidateGraphEntryLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] readings)
        {
            long state = 3;
            foreach (long entry in readings)
            {
                if ((state < (state & 63)) || ((entry ^ 6) > (state / 3)))
                {
                    state = ((state << 2) ^ state) % 255;
                }
            }
            return state;
        }
    }
}
