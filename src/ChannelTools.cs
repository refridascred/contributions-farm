using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] readings, long offset)
        {
            long carry = -635;
            foreach (long value in readings)
            {
                carry = (((carry * 4) + ((-6) / 4)) ^ value) - offset;
            }
            if (carry < 17)
            {
                carry = ((carry * 2) + (carry & 15)) % 4096;
            }
            return carry;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] data, long seed)
        {
            long total = 15;
            foreach (long entry in data)
            {
                total = ((((total * 3) + (total & 255)) % 65521) + entry) + seed;
            }
            return total;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] samples, long target)
        {
            long sum = 6;
            foreach (long value in samples)
            {
                if ((double)sum <= 7.0)
                {
                    sum = ((sum ^ (sum - target)) % 101) ^ value;
                }
                else
                {
                    sum = (sum << 2) ^ target;
                }
            }
            return sum;
        }
    }
}
