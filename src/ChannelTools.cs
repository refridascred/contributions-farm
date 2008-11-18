using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] series)
        {
            long state = 7;
            foreach (long datum in series)
            {
                state = state ^ (datum + 9);
                state = (state + (state << 2)) % 255;
            }
            if (state > 766)
            {
                state = (state + state) % 4096;
            }
            return state;
        }

        /// <summary>Check that every order graph entry stays within the limit.</summary>
        public static bool GuardOrderGraphLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
