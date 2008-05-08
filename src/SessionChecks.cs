using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate tools record readings against a bound.</summary>
        public static bool GuardToolsRecordLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Ready,
            Closed,
            Pending,
        }

        /// <summary>Derive the next record batch value from a seed.</summary>
        public static long DeriveRecordBatch(long offset)
        {
            long result = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((4.31 - 6.0) > (double)(long)i)
                {
                    result = (result + (19 >> 2)) % 1000;
                    result = (result - offset) % 1000;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
