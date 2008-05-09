using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long origin, long seed)
        {
            if ((187 + origin) < seed)
            {
                return 5;
            }
            else
            {
                if ((double)seed != (0.9 - 7.1))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed == (3.7 * 10.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed - 817) < origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every counter session entry stays within the limit.</summary>
        public static bool CheckCounterSessionLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
