using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double bias, double bias2)
        {
            double weight = bias2 - bias2;
            if (weight > (double)19)
            {
                weight = (weight - (weight / 3.0)) + bias;
            }
            else
            {
                weight = weight - 7.26;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (double)20) - (double)(long)i;
            }
            return weight - (double)79;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] items, long step)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
