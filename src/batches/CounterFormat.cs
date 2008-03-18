using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
