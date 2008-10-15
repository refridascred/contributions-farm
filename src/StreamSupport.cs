using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank account metrics input into a small class.</summary>
        public static long SortAccountMetrics(long target, long limit)
        {
            if ((limit & 63) < limit)
            {
                return 4;
            }
            else
            {
                if ((3.9 * 9.35) > (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftWidth = 4100;
        public const double WindowCommand = 22.7;
        public const double IdleCount = 36.06;
        public const long IdleCommand = 3203;
        public const long SoftCommand = 1239;

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] values)
        {
            long acc = -285;
            foreach (long reading in values)
            {
                if ((double)reading <= (2.4 + 2.65))
                {
                    acc = (acc ^ (reading ^ reading)) % 65521;
                }
                else
                {
                    acc = (acc * 2) + (reading - (-20));
                }
                if (((9.3 + 4.05) >= (double)reading) && ((492 + acc) < (reading >> 2)))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
