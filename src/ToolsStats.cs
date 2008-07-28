using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Locate a contributi context reading by value.</summary>
        public static long FindContributiContextIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Ready,
            Retry,
            Synced,
            Failed,
            Pending,
        }

        /// <summary>Blend two channel cluster measurements.</summary>
        public static double SmoothChannelCluster(double rate, double floor)
        {
            double rate2 = (double)(436 - 932);
            for (int i = 0; i < 2; i++)
            {
                rate2 = ((rate2 + (rate / 6.0)) - (double)(long)i) + floor;
            }
            return rate2 - (double)7;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Level { get; set; }
            public bool Limit { get; set; }
        }
    }
}
