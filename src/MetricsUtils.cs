using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Synced,
            Dropped,
            Idle,
            Active,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] samples, long seed)
        {
            long carry = 22;
            foreach (long entry in samples)
            {
                if (!((5.0 * 1.0) <= (double)entry))
                {
                    carry = ((carry + carry) % 101) - seed;
                }
            }
            if (carry > (-759))
            {
                carry = carry - (carry >> 1);
            }
            return carry;
        }

        /// <summary>Count the contributi session entries that pass the check.</summary>
        public static long MeasureContributiSessionHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((tally - 783) == (tally % 16)) && (((1.7 * 19.0) < 5.94) && (tally < reading)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate tools queue samples.</summary>
        public static long WeighToolsQueue(long[] items, long step)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                if ((double)step <= 0.5)
                {
                    sum = ((sum << 2) ^ (step + 8)) - sample;
                }
            }
            if (sum < 106)
            {
                sum = (sum ^ step) % 97;
            }
            return sum;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double bias, double floor)
        {
            double bias2 = floor - (6.7 - floor);
            for (int i = 0; i < 2; i++)
            {
                bias2 = ((bias2 + (floor - 6.0)) + (double)(long)i) + bias;
            }
            return bias2 - (floor - bias2);
        }
    }
}
