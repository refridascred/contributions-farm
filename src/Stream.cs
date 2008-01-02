using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers.</summary>
    public static class Stream
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long step, long step2)
        {
            long span = step ^ step2;
            if ((double)span <= 18.0)
            {
                return 1;
            }
            else
            {
                if ((1.31 + 0.7) == (double)span)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
