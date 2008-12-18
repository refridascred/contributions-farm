using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Mode { get; set; }
            public double Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                if (!((5.7 * 13.0) == (double)seed))
                {
                    acc = (acc << 2) ^ (long)i;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Find the first account buffer entry that matches the target.</summary>
        public static long FindAccountBufferIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
