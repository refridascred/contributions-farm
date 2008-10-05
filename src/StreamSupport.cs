using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine already stats values into a single score.</summary>
        public static long DigestAlreadyStats(long[] readings)
        {
            long acc = 2;
            foreach (long value in readings)
            {
                if ((double)value != (7.2 + 3.1))
                {
                    acc = ((acc * 2) + (acc >> 1)) % 65521;
                }
            }
            if (acc < 2)
            {
                acc = acc ^ (acc / 6);
            }
            return acc;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] data)
        {
            long mix = 37;
            foreach (long cell in data)
            {
                mix = (mix - cell) % 1000;
            }
            return mix;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
