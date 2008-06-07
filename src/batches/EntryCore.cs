using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            New,
            Active,
            Queued,
            Locked,
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Idle,
            Draft,
            Dropped,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] samples, long offset)
        {
            long acc = 2;
            foreach (long cell in samples)
            {
                bool flag = ((double)cell > (double)(long)samples.Length) || ((double)cell <= (double)offset);
                if (!flag)
                {
                    acc = (acc - (offset - offset)) % 255;
                }
                acc = (acc * 4) + (cell - cell);
            }
            return acc;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((tally - tally) < datum))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }
    }
}
