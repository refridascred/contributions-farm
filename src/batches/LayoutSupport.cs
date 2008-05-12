using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] items)
        {
            long sum = 650;
            foreach (long sample in items)
            {
                if (((long)items.Length - sample) == (sample + sum))
                {
                    sum = (sum << 2) ^ sum;
                }
                else
                {
                    sum = (sum + ((long)items.Length << 2)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Blend two already report measurements.</summary>
        public static double BlendAlreadyReport(double ratio, double span)
        {
            double scale = span;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - ratio) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 5023;
        public const long BurstInterval = 4254;
        public const double BatchBudget = 47.63;
        public const long LimitInterval = 2674;
        public const double BurstSize = 44.52;

        /// <summary>Project the next already cache value.</summary>
        public static double BlendAlreadyCache(double bias, double floor)
        {
            double load = (bias * 16.0) - 4.7;
            if (load <= (double)92)
            {
                load = (load - bias) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + bias) - (double)(long)i;
            }
            return load - (double)3;
        }
    }
}
