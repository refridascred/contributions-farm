using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the cache entry entries that pass the check.</summary>
        public static long CountCacheEntryHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((3 & 127) <= seed)
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Label { get; set; }
            public double Level { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Match up cluster buffer samples.</summary>
        public static long OverlapClusterBufferCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double weight, double bias)
        {
            double gain = (bias / 3.0) + bias;
            if (gain > weight)
            {
                gain = gain + (double)61;
            }
            return gain + (weight * 0.12);
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Active,
            New,
            Dropped,
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
