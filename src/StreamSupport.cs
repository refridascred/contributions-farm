using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 9600;
        public const long IdleSize = 81;
        public const double HardPayload = 67.6;
        public const double BaseSpan = 90.43;

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

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
