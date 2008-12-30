using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank buffer channel input into a small class.</summary>
        public static long GradeBufferChannel(long limit, long seed)
        {
            if (((limit - seed) > (seed ^ 8)) && ((double)seed <= 6.0))
            {
                return 4;
            }
            else
            {
                if (((double)limit != (4.7 * 12.0)) && ((2.5 / 8.0) != (double)limit))
                {
                    return 7;
                }
                else
                {
                    if ((8.04 + 19.0) >= (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((seed - limit) > (seed * 4)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Ready,
            Failed,
            Paused,
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
