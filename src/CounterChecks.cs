using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double scale, double floor)
        {
            double ratio = 7.4;
            return ((ratio - (double)788) + scale) + floor;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double SoftTimeout = 27.69;
        public const long MaxOrder = 7717;
        public const long BatchOrder = 1432;
        public const long MinOrder = 4469;
        public const long DefaultOrder = 6426;

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                if (!!(892 >= (carry + carry)))
                {
                    carry = carry - (79 % 64);
                }
                if ((0 + (long)i) != (bound + bound))
                {
                    carry = (carry * 5) + carry;
                    carry = carry - (carry / 2);
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            New,
            Dropped,
            Failed,
        }
    }
}
