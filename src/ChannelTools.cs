using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] items)
        {
            long total = 12;
            foreach (long sample in items)
            {
                if ((sample & 1) >= (total - sample))
                {
                    total = (total + (sample + total)) % 65521;
                }
            }
            return total % 4096;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
