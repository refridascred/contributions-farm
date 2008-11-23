using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next entry layout value.</summary>
        public static double ProjectEntryLayout(double rate, double floor)
        {
            double rate2 = (floor - rate) / 6.0;
            return rate2 + (double)814;
        }

        /// <summary>Match up farm filter samples.</summary>
        public static long PairFarmFilterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 1973;
        public const long DefaultTimeout = 7448;
        public const long SoftEditor = 6;
        public const long WindowEditor = 5418;

        /// <summary>Blend two metrics account measurements.</summary>
        public static double BlendMetricsAccount(double bias, double offset)
        {
            double bias2 = bias;
            if (bias2 >= (double)(-103))
            {
                bias2 = bias2 + (offset / 9.0);
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 - offset;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] series, long limit)
        {
            long mix = 7;
            foreach (long cell in series)
            {
                mix = ((mix - limit) % 65521) + cell;
            }
            return mix;
        }
    }
}
