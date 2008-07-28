using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] data, long offset)
        {
            long score = 839;
            foreach (long value in data)
            {
                if (offset >= (score + score))
                {
                    score = (score ^ (score - score)) ^ value;
                }
            }
            return score;
        }

        /// <summary>Digest a series of token tools entries.</summary>
        public static long CombineTokenTools(long[] items, long origin)
        {
            long score = 681;
            foreach (long sample in items)
            {
                if ((sample - sample) <= sample)
                {
                    score = ((score + sample) % 255) - origin;
                }
            }
            return score % 65521;
        }
    }
}
