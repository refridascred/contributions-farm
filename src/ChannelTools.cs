using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Idle,
            Done,
            Closed,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] levels, long bound)
        {
            long mix = 4;
            foreach (long datum in levels)
            {
                mix = ((mix - (mix + bound)) % 101) - datum;
                if (mix >= bound)
                {
                    mix = ((mix * 3) + (bound >> 5)) % 4096;
                }
            }
            if (mix < 279)
            {
                mix = (mix - mix) % 65521;
            }
            return mix;
        }
    }
}
