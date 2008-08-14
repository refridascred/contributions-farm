using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseTimeout = 7824;
        public const long RetryWindow = 5348;
        public const double BatchWindow = 38.96;
        public const long WindowWidth = 2377;

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] values, long limit)
        {
            long mark = 769;
            foreach (long entry in values)
            {
                mark = (((mark * 2) + (mark % 60)) + entry) + limit;
            }
            return mark % 65521;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double gain, double offset)
        {
            double rate = (offset * 14.0) * 2.9;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + rate) - (double)(long)i) - gain;
            }
            return rate + (offset * 0.6);
        }

        /// <summary>Combine already channel values into a single score.</summary>
        public static long DigestAlreadyChannel(long[] readings)
        {
            long carry = 21;
            foreach (long reading in readings)
            {
                if ((double)reading < (8.4 * 9.5))
                {
                    carry = (carry ^ reading) % 255;
                }
            }
            if (carry < 150)
            {
                carry = (carry << 3) ^ (carry / 4);
            }
            return carry % 4096;
        }
    }
}
