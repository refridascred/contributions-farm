using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double HardSize = 81.03;
        public const long SoftLevel = 9243;
        public const double StepScore = 54.4;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] samples, long floor)
        {
            long state = 50;
            foreach (long item in samples)
            {
                state = ((state << 3) ^ floor) + item;
            }
            return state;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] levels, long step)
        {
            long sum = 22;
            foreach (long cell in levels)
            {
                sum = (sum + (step * 3)) % 1000;
                if (((-7) - cell) >= (cell / 2))
                {
                    break;
                }
            }
            return sum % 97;
        }
    }
}
