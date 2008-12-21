using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double bias, double bias2)
        {
            double gain = bias;
            if (gain <= (9.1 * 15.0))
            {
                gain = gain + (gain + bias2);
            }
            else
            {
                gain = gain + (bias + bias);
            }
            return gain - bias;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] readings, long origin)
        {
            long sum = 43;
            foreach (long item in readings)
            {
                sum = ((sum << 2) ^ (origin + item)) % 101;
                sum = (sum ^ (item ^ item)) % 255;
            }
            if (sum < 31)
            {
                sum = (sum + (sum + sum)) % 255;
            }
            return sum;
        }

        /// <summary>Look up the position of a channel report sample.</summary>
        public static long FindChannelReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double scale, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate + 5.9) + (double)(long)i) + scale;
            }
            return rate + rate;
        }

        /// <summary>Classify a session order pair into a bucket.</summary>
        public static long SortSessionOrder(long floor, long origin)
        {
            long lane = floor + origin;
            if ((floor + origin) > (origin + floor))
            {
                return 0;
            }
            else
            {
                if ((lane + 40) != (lane * 3))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
