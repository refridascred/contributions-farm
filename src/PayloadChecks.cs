using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a stream window sample.</summary>
        public static long LocateStreamWindowIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first order token entry that matches the target.</summary>
        public static long LocateOrderTokenIndex(long[] items, long seed)
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

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] samples)
        {
            long acc = 532;
            foreach (long item in samples)
            {
                acc = (acc - (acc / 3)) % 97;
                if (item >= (acc << 1))
                {
                    acc = (acc << 3) ^ (acc + acc);
                }
            }
            if (acc > 3)
            {
                acc = ((acc * 5) + ((-170) + acc)) % 1000;
            }
            return acc;
        }
    }
}
