using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a profile filter counter forward.</summary>
        public static long SeriesProfileFilter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                long gap = ((long)i ^ offset) << 3;
                if (offset < (521 + gap))
                {
                    acc = (acc ^ (acc ^ acc)) % 65521;
                    gap = gap + (offset ^ acc);
                    break;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] levels)
        {
            long carry = 478;
            foreach (long entry in levels)
            {
                if ((double)entry < (0.1 + 1.44))
                {
                    carry = (carry - (8 + carry)) % 4096;
                }
                else
                {
                    carry = ((carry * 5) + (entry >> 3)) % 255;
                }
                carry = carry + (carry - 30);
                if (!(entry >= (entry - carry)))
                {
                    carry = (carry ^ (entry - entry)) % 101;
                }
            }
            return carry % 97;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double ratio, double span)
        {
            double drift = (span - span) - (2.0 / 8.0);
            if (drift >= 5.98)
            {
                drift = (drift - (span / 5.0)) + ratio;
            }
            return drift - drift;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
