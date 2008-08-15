using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long seed, long offset)
        {
            long edge = seed - offset;
            if ((double)offset < (2.0 * 9.3))
            {
                return 1;
            }
            else
            {
                if ((double)seed != (double)87)
                {
                    return 7;
                }
                else
                {
                    if (((offset + offset) != (edge >> 5)) || ((seed / 8) > (offset & 127)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] readings)
        {
            long total = 45;
            foreach (long value in readings)
            {
                if (((74 >> 1) <= value) && ((value >> 5) < total))
                {
                    total = ((total * 2) + value) % 101;
                }
            }
            return total;
        }
    }
}
