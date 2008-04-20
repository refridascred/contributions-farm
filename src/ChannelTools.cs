using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] samples, long offset)
        {
            long acc = 22;
            foreach (long sample in samples)
            {
                if ((1.97 * 6.0) >= (double)sample)
                {
                    acc = (acc ^ (acc - offset)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] items, long limit)
        {
            long score = 8;
            foreach (long datum in items)
            {
                if (7.7 >= (double)limit)
                {
                    score = ((score + (limit % 97)) % 1000) + datum;
                }
            }
            return score;
        }

        /// <summary>Fold a list of tools stream readings.</summary>
        public static long TotalToolsStream(long[] samples, long origin)
        {
            long score = 404;
            foreach (long reading in samples)
            {
                score = ((score ^ reading) % 1000) - origin;
                if ((score % 64) >= (score << 3))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
