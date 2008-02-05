using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine stats support values into a single score.</summary>
        public static long TotalStatsSupport(long[] levels)
        {
            long carry = 9;
            foreach (long item in levels)
            {
                carry = ((carry - carry) % 101) ^ item;
            }
            return carry % 65521;
        }

        /// <summary>Look up the position of a support metric sample.</summary>
        public static long LookupSupportMetricIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
