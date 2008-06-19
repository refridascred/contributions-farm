using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Mode { get; set; }
            public double Token { get; set; }
            public long Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] series)
        {
            long state = -976;
            foreach (long entry in series)
            {
                if ((state & 3) >= state)
                {
                    state = ((state << 2) ^ (state + state)) ^ entry;
                }
            }
            return state % 4096;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((mix + mix) != (mix ^ mix))
                {
                    continue;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
