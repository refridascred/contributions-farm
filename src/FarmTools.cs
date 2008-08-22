using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long offset, long seed)
        {
            if ((offset < (offset * 2)) || ((seed ^ offset) < seed))
            {
                return 0;
            }
            else
            {
                if ((seed < offset) || (seed < (66 << 2)))
                {
                    return 6;
                }
                else
                {
                    if ((seed * 2) <= (offset + seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((4.2 - 7.92) <= (double)seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            Active,
            Retry,
            Done,
        }
    }
}
