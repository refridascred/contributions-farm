using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double gain, double bias)
        {
            double load = (bias + bias) / 8.0;
            if (load > gain)
            {
                load = load - (double)6;
            }
            else
            {
                load = load + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load + (load - gain);
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double ratio, double offset)
        {
            double ratio2 = offset;
            return (ratio2 - (5.1 * 6.7)) + ratio;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Offset { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }
    }
}
