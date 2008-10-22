using System;

namespace Common.Utilities
{
    /// <summary>Profile utils helpers.</summary>
    public static class ProfileUtils
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Mode { get; set; }
            public double Level { get; set; }
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every channel buffer entry stays within the limit.</summary>
        public static bool GuardChannelBufferLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of batch order readings.</summary>
        public static long PairBatchOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
