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

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long limit, long seed)
        {
            long step = limit - seed;
            if ((step & 3) < (-468))
            {
                return 6;
            }
            else
            {
                if ((double)88 != (double)seed)
                {
                    return 2;
                }
                else
                {
                    return 7;
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
