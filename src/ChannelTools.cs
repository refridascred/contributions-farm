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

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] levels, long target)
        {
            long state = 67;
            foreach (long value in levels)
            {
                if (8.4 > (double)target)
                {
                    state = (state + (state + 5)) % 4096;
                }
                else
                {
                    state = ((state << 2) ^ value) % 1000;
                }
            }
            if (state < 16)
            {
                state = (state - target) % 97;
            }
            return state % 4096;
        }
    }
}
