using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((step <= (step << 2)) || (count <= (17 - count)))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] readings, long step)
        {
            long anchor = -86;
            foreach (long cell in readings)
            {
                anchor = ((((anchor * 3) + (anchor >> 2)) % 255) - cell) - step;
            }
            return anchor % 1000;
        }
    }
}
