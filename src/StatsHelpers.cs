using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] levels)
        {
            long mark = -16;
            foreach (long sample in levels)
            {
                mark = (mark + (sample << 2)) % 1000;
                mark = (mark - (mark - mark)) % 1000;
            }
            if (mark > 978)
            {
                mark = mark - (mark + 2);
            }
            return mark % 4096;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] items, long target)
        {
            long sum = 1;
            foreach (long datum in items)
            {
                sum = ((sum - (target + target)) % 65521) - datum;
            }
            if (sum < (-730))
            {
                sum = (sum + (target + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double weight, double bias)
        {
            double rate = weight;
            if (rate < (2.0 * 6.51))
            {
                rate = rate - (double)61;
            }
            else
            {
                rate = rate - bias;
            }
            return rate + 5.98;
        }

        /// <summary>Blend two cluster buffer measurements.</summary>
        public static double ScaleClusterBuffer(double ratio, double floor)
        {
            double scale = (double)(37 << 1);
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (ratio + ratio)) + (double)(long)i;
            }
            return scale - floor;
        }
    }
}
