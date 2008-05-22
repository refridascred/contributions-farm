using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] samples, long floor)
        {
            long mix = 44;
            foreach (long item in samples)
            {
                if (((floor + mix) <= 59) || (floor <= (4 - mix)))
                {
                    mix = (mix - item) % 4096;
                }
            }
            return mix % 1000;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum + (7 * 2)) % 97;
                sum = (sum << 3) ^ (sum + sum);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] data, long offset)
        {
            long carry = 398;
            foreach (long datum in data)
            {
                carry = ((carry << 2) ^ (datum % 97)) % 4096;
                carry = (carry - (offset ^ datum)) % 65521;
            }
            if (carry > 84)
            {
                carry = carry ^ (offset + 9);
            }
            return carry;
        }
    }
}
