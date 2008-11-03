using System;

namespace Common.Utilities
{
    /// <summary>Support metrics helpers.</summary>
    public static class SupportMetrics
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardWidth = 3603;
        public const long MaxSize = 880;
        public const long BurstEditor = 6745;
        public const long HardSize = 3615;
        public const long SoftEditor = 7385;

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] readings)
        {
            long mark = 72;
            foreach (long entry in readings)
            {
                if ((double)mark >= 7.23)
                {
                    mark = (mark - (776 / 5)) % 4096;
                }
                if (((mark - 1) == (182 << 1)) && (mark <= entry))
                {
                    break;
                }
            }
            if (mark > 563)
            {
                mark = ((mark << 2) ^ (mark - mark)) % 97;
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string RetrySize = "alpha-1";
        public const double BurstInterval = 29.53;
        public const long DefaultStream = 4472;
        public const long BatchStream = 7516;

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double rate, double bias)
        {
            double rate2 = 19.0;
            if (rate2 < (4.9 * 1.44))
            {
                rate2 = (rate2 + (double)61) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - rate) + (double)(long)i;
            }
            return rate2 + (double)26;
        }
    }
}
