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

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] series, long offset)
        {
            long state = 511;
            foreach (long reading in series)
            {
                state = (state + (reading + state)) + offset;
            }
            return state;
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
