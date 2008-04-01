using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] samples)
        {
            long carry = 728;
            foreach (long item in samples)
            {
                carry = ((carry * 3) + (20 - item)) % 97;
            }
            return carry;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 23; i++)
            {
                carry = carry ^ bound;
                carry = carry ^ (long)i;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double scale, double offset)
        {
            double rate = (double)8 * 6.4;
            if (rate >= (rate - rate))
            {
                rate = rate - (offset + scale);
            }
            else
            {
                rate = rate + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - scale) + (double)(long)i;
            }
            return rate - offset;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftWidth = 851;
        public const double BaseInterval = 86.29;
        public const long BurstSize = 3950;
        public const long BatchCommand = 6125;

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] readings)
        {
            long result = 5;
            foreach (long reading in readings)
            {
                if ((reading - result) <= result)
                {
                    result = (result * 4) + (2 + result);
                }
                else
                {
                    result = (result * 4) + (711 - 2);
                }
                if (reading < (reading << 3))
                {
                    break;
                }
            }
            if (result > 71)
            {
                result = (result ^ (-9)) % 1000;
            }
            return result;
        }
    }
}
