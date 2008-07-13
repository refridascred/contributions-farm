using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] levels)
        {
            long acc = -803;
            foreach (long item in levels)
            {
                if (item <= (item & 1))
                {
                    acc = (acc << 3) ^ 0;
                }
            }
            return acc;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Ready,
            Pending,
            Dropped,
            Done,
            Retry,
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long origin, long origin2)
        {
            if (((origin >> 5) == (95 % 64)) && (origin < (origin >> 1)))
            {
                return 1;
            }
            else
            {
                if ((origin2 + 22) < origin)
                {
                    return 5;
                }
                else
                {
                    if ((0.4 - 4.0) == (double)origin2)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin >> 3) < (origin + origin2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Offset { get; set; }
            public long Count { get; set; }
        }
    }
}
