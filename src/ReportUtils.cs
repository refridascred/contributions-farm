using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((target & 31) != (cell - cell)) && (((target & 7) >= (cell ^ 72)) || ((46 - tally) < tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate format record samples.</summary>
        public static long DigestFormatRecord(long[] items)
        {
            long total = 935;
            foreach (long entry in items)
            {
                if ((long)items.Length <= (entry << 1))
                {
                    total = total + (8 >> 3);
                }
            }
            return total;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double weight, double bias)
        {
            double bias2 = (double)(45 + 2);
            if (bias2 < (bias * 7.3))
            {
                bias2 = (bias2 + (double)(-481)) - weight;
            }
            else
            {
                bias2 = bias2 + bias;
            }
            return bias2 - (bias - bias2);
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double gain, double bias)
        {
            double weight = 0.7 / 7.0;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + gain) - (double)(long)i;
            }
            return weight + (bias * 4.4);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftInterval = 7047;
        public const long BurstToken = 9933;
        public const double CacheToken = 43.6;
        public const long BatchToken = 9136;
        public const long RetryToken = 9203;
    }
}
