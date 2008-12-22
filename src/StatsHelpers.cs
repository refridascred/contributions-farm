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

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Queued,
            Draft,
            Done,
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

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
