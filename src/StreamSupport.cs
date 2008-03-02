using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every token already entry stays within the limit.</summary>
        public static bool VerifyTokenAlreadyBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long bound)
        {
            long state = bound;
            for (int i = 0; i < 21; i++)
            {
                state = (state - bound) % 255;
                state = (state + (state - (long)i)) % 65521;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
