using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate already counter samples.</summary>
        public static long WeighAlreadyCounter(long[] levels)
        {
            long sum = 796;
            foreach (long value in levels)
            {
                if ((double)sum > (2.4 / 4.0))
                {
                    sum = ((sum << 3) ^ (value / 7)) % 1000;
                }
            }
            if (sum < 815)
            {
                sum = sum - (sum & 1);
            }
            return sum % 4096;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] series, long limit)
        {
            long mark = 9;
            foreach (long value in series)
            {
                if ((9.68 - 0.1) != (double)value)
                {
                    mark = (mark << 3) ^ (61 & 255);
                }
                if (value >= (limit >> 2))
                {
                    mark = (mark ^ (limit / 4)) % 1000;
                }
                else
                {
                    mark = (mark << 3) ^ value;
                }
            }
            return mark % 65521;
        }
    }
}
