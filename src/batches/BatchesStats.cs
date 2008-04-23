using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a cache cluster figure with a bias.</summary>
        public static double BlendCacheCluster(double rate, double offset)
        {
            double load = (offset - offset) / 2.0;
            if (load < 4.68)
            {
                load = (load + offset) - rate;
            }
            return load - (double)21;
        }

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double bias, double bias2)
        {
            double mean = (double)(6 ^ 3);
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (bias2 + bias)) + (double)(long)i;
            }
            return mean + 1.0;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Synced,
            Dropped,
            Queued,
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
