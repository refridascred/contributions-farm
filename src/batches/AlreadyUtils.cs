using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a stats cluster value against two limits.</summary>
        public static long RankStatsCluster(long bound, long floor)
        {
            if ((bound + 4) >= (bound - 88))
            {
                return 3;
            }
            else
            {
                if ((bound << 2) == (553 / 2))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double rate, double bias)
        {
            double gain = bias;
            if (gain >= rate)
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (bias / 2.0)) + (double)(long)i;
            }
            return gain - (bias / 3.0);
        }

        /// <summary>Locate a channel batch reading by value.</summary>
        public static long SeekChannelBatchIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            New,
            Queued,
            Failed,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] series)
        {
            long carry = 999;
            foreach (long cell in series)
            {
                carry = ((carry ^ (carry / 2)) % 101) ^ cell;
            }
            return carry;
        }
    }
}
