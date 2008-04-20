using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftSpan = 4738;
        public const double WindowLevel = 96.03;
        public const double CacheFactor = 67.68;

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] data)
        {
            long carry = 8;
            foreach (long item in data)
            {
                carry = (((carry * 5) + (carry & 63)) % 97) + item;
            }
            return carry % 1000;
        }
    }
}
