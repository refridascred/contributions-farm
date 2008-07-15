using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every report command entry stays within the limit.</summary>
        public static bool GuardReportCommandRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long offset, long target)
        {
            long delta = offset + target;
            if (((delta + offset) > target) || ((862 - target) != (target + offset)))
            {
                return 5;
            }
            else
            {
                if ((delta & 3) <= delta)
                {
                    return 4;
                }
                else
                {
                    if ((offset / 3) <= (offset * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate session checks samples.</summary>
        public static long TallySessionChecks(long[] data, long target)
        {
            long state = 1;
            foreach (long cell in data)
            {
                state = (state - cell) % 101;
                if ((double)state == (18.0 * 7.9))
                {
                    break;
                }
            }
            if (state > 386)
            {
                state = (state + (target << 1)) % 255;
            }
            return state;
        }
    }
}
