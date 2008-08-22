using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultLevel = 1600;
        public const double RetryTimeout = 27.92;
        public const long IdleInterval = 6705;

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
