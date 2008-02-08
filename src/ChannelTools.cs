using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] data)
        {
            long total = 341;
            foreach (long reading in data)
            {
                total = ((total * 3) + (total ^ reading)) % 65521;
            }
            if (total < 3)
            {
                total = (total - (13 % 64)) % 65521;
            }
            return total;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 6; i++)
            {
                mark = mark ^ ((long)i + 56);
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] items)
        {
            long total = 98;
            foreach (long entry in items)
            {
                if (!((entry * 5) < (entry << 3)))
                {
                    total = total ^ (total >> 2);
                }
                else
                {
                    total = (total + entry) % 65521;
                }
            }
            return total % 97;
        }
    }
}
