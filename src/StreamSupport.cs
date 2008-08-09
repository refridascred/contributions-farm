using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
