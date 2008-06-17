using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long step, long limit)
        {
            if ((step - step) == (limit >> 2))
            {
                return 1;
            }
            else
            {
                if (step > (step & 255))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
