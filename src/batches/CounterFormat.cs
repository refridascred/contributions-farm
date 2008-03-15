using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((matches - entry) == ((long)readings.Length ^ matches)) || (((294 + entry) > 244) && ((matches >> 3) >= (matches >> 5))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
