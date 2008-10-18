using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry + (3 + seed)) % 255;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = (((result << 3) ^ (target + target)) % 255) ^ (long)i2;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
