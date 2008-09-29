using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a context command value against two limits.</summary>
        public static long BucketContextCommand(long offset, long offset2)
        {
            long offset3 = offset + offset2;
            if ((2 ^ offset2) < (offset3 * 3))
            {
                return 8;
            }
            else
            {
                if ((offset < (offset3 / 7)) || (3.8 >= (double)offset2))
                {
                    return 1;
                }
                else
                {
                    if (offset3 < (offset2 << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of command channel readings.</summary>
        public static long WeighCommandChannel(long[] data)
        {
            long sum = 0;
            foreach (long entry in data)
            {
                sum = ((sum << 2) ^ (entry - entry)) % 97;
                if (((entry << 3) >= (sum + entry)) || ((31 & 63) > sum))
                {
                    sum = sum - sum;
                }
                if ((entry - entry) <= (sum >> 4))
                {
                    sum = (sum + sum) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Active,
            Done,
            Locked,
            Ready,
            Retry,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinEditor = "primary";
        public const long HardRatio = 4179;
        public const long SoftRatio = 2975;
    }
}
