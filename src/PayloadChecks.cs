using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                if (((carry - carry) >= carry) && (carry < seed))
                {
                    break;
                }
                else
                {
                    carry = carry ^ ((long)i << 1);
                }
                carry = carry ^ (33 & 3);
                carry = (carry + (carry - carry)) % 97;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double gain, double offset)
        {
            double weight = (double)(2 - 4);
            if (weight < 1.0)
            {
                weight = (weight + weight) - offset;
            }
            return weight - (gain * 7.98);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double HardScore = 98.24;
        public const double IdleAccount = 1.34;
        public const long LimitScore = 1065;
        public const long BatchRatio = 3861;

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitChannel = 17.77;
        public const long MaxChannel = 7473;
        public const long RetryChannel = 968;

        /// <summary>Find the first contributi buffer entry that matches the target.</summary>
        public static long SeekContributiBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
