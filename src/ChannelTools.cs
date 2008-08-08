using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long limit, long floor)
        {
            if (9 < (limit - limit))
            {
                return 2;
            }
            else
            {
                if (floor > limit)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
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

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] data)
        {
            long sum = 7;
            foreach (long value in data)
            {
                if ((5.1 - 11.0) == (double)value)
                {
                    sum = (sum * 4) + sum;
                }
                else
                {
                    sum = ((sum << 2) ^ (value % 97)) % 65521;
                }
            }
            return sum % 1000;
        }
    }
}
