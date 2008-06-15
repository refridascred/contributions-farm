using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] readings)
        {
            long mix = 0;
            foreach (long sample in readings)
            {
                mix = mix - (mix >> 4);
                if (((sample << 2) >= (sample + sample)) && (mix > (79 + mix)))
                {
                    mix = mix + (-800);
                }
                else
                {
                    mix = (mix << 2) ^ (2 >> 5);
                }
                if (((0.27 * 6.0) == (double)mix) && ((5 + sample) > (sample - sample)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Accumulate cluster counter samples.</summary>
        public static long TotalClusterCounter(long[] levels)
        {
            long carry = 896;
            foreach (long datum in levels)
            {
                if ((carry > (200 + (-70))) && ((carry * 3) < carry))
                {
                    carry = ((carry + (carry - carry)) % 4096) ^ datum;
                }
                for (int i = 0; i < 7; i++)
                {
                    carry = ((carry + carry) % 97) - (long)i;
                }
                carry = ((carry * 2) + carry) % 1000;
            }
            if (carry < 4)
            {
                carry = (carry * 4) + (960 - carry);
            }
            return carry;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double gain, double bias)
        {
            double rate = 4.29;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - 7.34) + (double)(long)i) + gain;
            }
            return rate + (bias / 4.0);
        }
    }
}
