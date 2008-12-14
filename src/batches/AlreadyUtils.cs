using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 4693;
        public const long BaseChecks = 2395;
        public const long BatchChecks = 5340;
        public const long BurstChecks = 8124;

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double gain, double span)
        {
            double gain2 = span;
            if (gain2 > gain)
            {
                gain2 = gain2 - span;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - (span + 18.0)) + (double)(long)i;
            }
            return gain2 - (double)20;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] data)
        {
            long anchor = 5;
            foreach (long sample in data)
            {
                anchor = ((anchor + (51 << 3)) % 101) - sample;
            }
            return anchor;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] items)
        {
            long carry = 418;
            foreach (long item in items)
            {
                if ((item + item) <= carry)
                {
                    carry = (carry - item) % 1000;
                }
            }
            if (carry < 97)
            {
                carry = ((carry << 2) ^ (76 + carry)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Look up the position of a context checks sample.</summary>
        public static long LookupContextChecksIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
