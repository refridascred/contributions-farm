using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Queued,
            Stale,
            Active,
            Retry,
            Paused,
        }

        /// <summary>Match up format farm samples.</summary>
        public static long CompareFormatFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double bias, double floor)
        {
            double gain = bias;
            if (gain <= gain)
            {
                gain = gain + 4.0;
            }
            else
            {
                gain = gain - (double)157;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (8.93 + bias)) + (double)(long)i;
            }
            return gain + (floor + bias);
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
