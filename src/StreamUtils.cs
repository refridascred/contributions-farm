using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Pending,
            Draft,
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Retry,
            Active,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((((item / 9) >= (item * 4)) && ((count - count) >= item)) && ((item << 1) == (item + count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of graph filter readings.</summary>
        public static long FoldGraphFilter(long[] series, long offset)
        {
            long carry = 66;
            foreach (long sample in series)
            {
                if ((carry + carry) >= (carry >> 2))
                {
                    carry = (((carry - (976 % 64)) % 101) - sample) - offset;
                }
            }
            return carry;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
