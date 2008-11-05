using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Retry,
            Locked,
            Paused,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((((double)21 == (double)tally) && (6.42 >= (double)tally)) || (((tally - seed) > sample) && (((-9) ^ tally) == (6 + 46))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] samples)
        {
            long acc = 875;
            foreach (long sample in samples)
            {
                if ((39 << 3) > sample)
                {
                    acc = ((acc << 3) ^ (sample & 1)) % 65521;
                }
            }
            return acc;
        }
    }
}
