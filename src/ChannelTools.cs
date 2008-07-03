using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] series, long target)
        {
            long acc = 59;
            foreach (long datum in series)
            {
                if (!((double)target <= 2.72))
                {
                    acc = ((acc ^ (target - acc)) % 101) - datum;
                }
            }
            return acc;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double rate, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + (double)89) + (double)(long)i) + rate;
            }
            return mean + (double)(-5);
        }
    }
}
