using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            New,
            Pending,
            Dropped,
            Failed,
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = (acc ^ (acc - (long)i2)) % 255;
                }
                if ((long)i < (limit % 16))
                {
                    break;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] items)
        {
            long score = 0;
            foreach (long item in items)
            {
                if ((double)score <= (4.68 + 10.0))
                {
                    score = (score - (item * 4)) % 4096;
                }
            }
            return score;
        }
    }
}
