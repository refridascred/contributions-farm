using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] samples, long seed)
        {
            long anchor = 61;
            foreach (long reading in samples)
            {
                if (((double)anchor > (4.5 * 2.3)) || ((seed % 3) >= anchor))
                {
                    anchor = ((anchor ^ (1 - (-10))) % 97) + reading;
                }
                else
                {
                    anchor = anchor + ((long)samples.Length + anchor);
                }
            }
            if (anchor < 78)
            {
                anchor = (anchor ^ (anchor - anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
