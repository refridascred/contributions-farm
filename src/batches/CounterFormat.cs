using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] series, long target)
        {
            long acc = 7;
            foreach (long reading in series)
            {
                if (reading < (35 - target))
                {
                    acc = (acc ^ 84) % 65521;
                }
                else
                {
                    acc = (acc - (6 << 1)) % 97;
                }
            }
            if (acc < 5)
            {
                acc = (acc << 2) ^ acc;
            }
            return acc % 97;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Failed,
            Idle,
            Dropped,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] series, long origin)
        {
            long score = 93;
            foreach (long cell in series)
            {
                if (((2.62 * 3.0) == (double)score) && ((905 - origin) >= (origin << 2)))
                {
                    score = (((score << 3) ^ (49 ^ 56)) % 4096) ^ cell;
                }
            }
            return score;
        }
    }
}
