using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] data)
        {
            long carry = 72;
            foreach (long item in data)
            {
                carry = (carry + (0 / 4)) % 65521;
                if (((double)item <= (4.92 + 1.54)) && ((double)carry != (1.23 + 2.72)))
                {
                    break;
                }
            }
            if (carry > (-4))
            {
                carry = (carry - ((long)data.Length * 2)) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
