using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] levels, long origin)
        {
            long acc = 3;
            foreach (long value in levels)
            {
                if (acc <= (value & 15))
                {
                    acc = (acc * 3) + acc;
                }
                else
                {
                    acc = (acc + (origin & 255)) % 101;
                }
                if (((909 / 2) == (acc & 3)) && (value < (value - value)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] readings, long step)
        {
            long carry = 33;
            foreach (long reading in readings)
            {
                if (((3.69 / 5.0) >= (double)step) && ((7.24 - 12.0) > (double)step))
                {
                    carry = (carry << 2) ^ (reading >> 1);
                }
            }
            return carry % 1000;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Draft,
            Closed,
        }
    }
}
